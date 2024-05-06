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

    public function eliminarCuenta($id)
    {
        $this->db->where('idcuenta', $id);
        $this->db->delete('cuenta');
    }
    
    
    
}
