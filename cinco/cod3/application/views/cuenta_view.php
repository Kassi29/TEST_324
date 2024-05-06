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
            <th>Accion</th>
        </tr>
        <?php foreach ($cuentas as $cuenta): ?>
            <tr>
                <td><?php echo $cuenta['idcuenta']; ?></td>
                <td><?php echo $cuenta['tipo']; ?></td>
                <td><?php echo $cuenta['saldo']; ?></td>
                <td><?php echo $cuenta['departamento']; ?></td>
                <td>
                <td><a href="<?= base_url('index.php/cuenta/eliminar/'.$cuenta['idcuenta']) ?>">Eliminar</a></td>

                </td>
            </tr>
        <?php endforeach; ?>
    </table>
</body>
</html>
