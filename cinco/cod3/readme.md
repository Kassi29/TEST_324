## Pregunta 5

Para realizar un listado de cuentas en **CodeIgniter** y permitir la posibilidad de eliminar alguna cuenta, se requiere seguir los siguientes pasos:

### Configuración del Entorno

1. Utilizar **XAMPP** con Apache y MySQL.
2. Acceder a **phpMyAdmin** con las credenciales de administrador `admin` y contraseña `123456`.
3. Crear una base de datos llamada `cinco`.

### Creación de Tablas

```sql
CREATE TABLE cuenta (
    idcuenta INT AUTO_INCREMENT PRIMARY KEY,
    tipo VARCHAR(20) NOT NULL,
    saldo DECIMAL(10, 2) NOT NULL,
    idcliente INT NOT NULL,
    departamento VARCHAR(100), 
    FOREIGN KEY (idcliente) REFERENCES persona(idpersona)
);

CREATE TABLE Usuarios (
    ID INT PRIMARY KEY,
    Nombre VARCHAR(50),
    Apellido VARCHAR(50),
    Contra INT
);

CREATE TABLE persona (
    idpersona INT AUTO_INCREMENT PRIMARY KEY,
    nombre VARCHAR(100) NOT NULL,
    apellido VARCHAR(100) NOT NULL,
    direccion VARCHAR(255),
    telefono VARCHAR(15)
);
```

### Configuración de Conexión a la Base de Datos en CodeIgniter

En el archivo `database.php` de CodeIgniter, se establece la conexión a la base de datos `cinco` con las siguientes configuraciones:

```php
$db['cinco'] = array(
    'dsn' => '',
    'hostname' => 'localhost',
    'username' => 'admin',
    'password' => '123456',
    'database' => 'cinco',
    'dbdriver' => 'mysqli',
    'dbprefix' => '',
    'pconnect' => FALSE,
    'db_debug' => (ENVIRONMENT !== 'production'),
    'cache_on' => FALSE,
    'cachedir' => '',
    'char_set' => 'utf8',
    'dbcollat' => 'utf8_general_ci',
    'swap_pre' => '',
    'encrypt' => FALSE,
    'compress' => FALSE,
    'stricton' => FALSE,
    'failover' => array(),
    'save_queries' => TRUE,
    'port' => 3307,
);
```

### Creación del Modelo

```php
<?php
class Cuenta_model extends CI_Model {
    public function __construct() {
        parent::__construct();
        $this->load->database();
    }
    public function obtener_cuentas() {
        $query = $this->db->get('cuenta');
        return $query->result_array();
    }
    public function eliminarCuenta($id) {
        $this->db->where('idcuenta', $id);
        $this->db->delete('cuenta');
    }
}
?>
```

### Creación del Controlador

```php
<?php
defined('BASEPATH') OR exit('No direct script access allowed');
class Cuenta extends CI_Controller {
    public function __construct() {
        parent::__construct();
        $this->load->model('Cuenta_model');
    }
    public function index() {
        $data['cuentas'] = $this->Cuenta_model->obtener_cuentas();
        $this->load->view('cuenta_view', $data);
    }
    public function eliminar($idcuenta) {
        $this->Cuenta_model->eliminarCuenta($idcuenta);
        $this->index();
    }
}
?>
```

### Creación de la Vista

```html
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Listado de Cuentas</title>
</head>
<body>
    <h1>Listado de Cuentas</h1>
    <table>
        <tr>
            <th>ID</th>
            <th>Tipo</th>
            <th>Saldo</th>
            <th>Departamento</th>
            <th>Acción</th>
        </tr>
        <?php foreach ($cuentas as $cuenta): ?>
        <tr>
            <td><?php echo $cuenta['idcuenta']; ?></td>
            <td><?php echo $cuenta['tipo']; ?></td>
            <td><?php echo $cuenta['saldo']; ?></td>
            <td><?php echo $cuenta['departamento']; ?></td>
            <td>
                <a href="<?= base_url('index.php/cuenta/eliminar/'.$cuenta['idcuenta']) ?>">Eliminar</a>
            </td>
        </tr>
        <?php endforeach; ?>
    </table>
</body>
</html>
```

Este proceso permite listar las cuentas almacenadas en la base de datos y ofrece la opción de eliminar alguna cuenta seleccionada.