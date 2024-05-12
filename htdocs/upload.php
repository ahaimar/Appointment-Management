
<?php

  move_uploaded_file($_FILES["file"]["tmp_name"],"images/". basename($_FILES["file"]["name"]));
 
?>
