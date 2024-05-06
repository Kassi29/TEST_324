<?php
defined('BASEPATH') OR exit('No direct script access allowed');

class Cuenta extends CI_Controller {

    public function __construct() {
        parent::__construct();
        $this->load->model('Cuenta_model'); // Carga el modelo aquí
    }

    public function index() {
        $data['cuentas'] = $this->Cuenta_model->obtener_cuentas(); // Accede al modelo con $this->cuenta_model
        $this->load->view('cuenta_view', $data);
    }
    public function eliminar($idcuenta) {
        $this->Cuenta_model->eliminarCuenta($idcuenta);
        
        $this->index();
    }
    
}