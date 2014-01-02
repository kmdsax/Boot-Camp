<?php
class Class1
{
    const DEFAULT_VALUE = "TEST";
    private $_field1;

    private function resetProperty1(){
        throw new Exception("resetProperty1() not implemented.");
    }

    public function getProperty1()
    {
        return $this->_field1;
    }
    public function initialize(){
        $this->resetProperty1();
    }
}