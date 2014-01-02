<?php
require_once "Class1.php";

$a = new Class1();
$a->initialize();
echo "The property value is: {a->getProperty1()}\n";