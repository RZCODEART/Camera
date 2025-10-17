# CAMERA

Configuramos dos cámaras virtuales con diferentes zonas de seguimiento al jugador.

## Camera001

<img src="Images\Camera001__.gif" width="100%">

<img src="Images\Camera001.gif" width="100%">

<img src="Images\Camera001_01.png" width="100%">

<img src="Images\Camera001_02.png" width="100%">

<img src="Images\DatosCamera001.png" width="100%">

## Camera002

<img src="Images\Camera002.gif" width="100%">

<img src="Images\Camera002_01.png" width="100%">

<img src="Images\Camera002_02.png" width="100%">

<img src="Images\DatosCamera002.png" width="100%">

Definimos un área de confinamiento diferente para cada una de las dos cámaras.

## Camera001

Confinamiento a través de un Box Collider 2D.

<img src="Images\Camera001ZonaDeConfinamiento.gif" width="100%">

<img src="Images\Camera001ZonaDeConfinamiento.png" width="100%">

## Camera002

Confinamiento a través de un Composite Collider 2D.

<img src="Images\Camera002_CompositerCollider.gif" width="100%">

<img src="Images\Camera002_CompositeCollider.png" width="100%">

Seguimiento a un grupo de objetivos:


## Create Target Group // 3 Sprites

<img src="Images\TargetGroup_3.gif" width="100%">

<img src="Images\TargetGroup_3_2.gif" width="100%">

<img src="Images\TargetGroup_3_Datos_1.png" width="100%">

<img src="Images\TargetGroup_3_Datos_2.png" width="100%">


## Create Target Group // 5 Sprites

<img src="Images\TargetGroup_5.gif" width="100%">

<img src="Images\TargetGroup_5_2.gif" width="100%">

<img src="Images\TargetGroup_5_Datos_1.png" width="100%">

<img src="Images\TargetGroup_5_Datos_2.png" width="100%">

Se implementó un zoom en la cámara del jugador que se controla con las teclas W y S. Para esto, se utilizó el eje Vertical del Input Manager, ya que este eje agrupa los comandos para ambas teclas.  

<img src="Images\Camera_Wide_Short_.gif" width="100%">

<img src="Images\Camera_Wide_Short_2.gif" width="100%">

<img src="Images\Camera_W_S_001.png" width="100%">

Seleccionamos un conjunto de teclas que permiten cambiar entre dos cámaras; en nuestro caso, hemos activado el teclado numérico 1 y 2.

<img src="Images\ChangeCamera.gif" width="100%">

<img src="Images\ChangeCamaraUI (2).png" width="100%">
<img src="Images\ChangeCamaraUI (1).png" width="100%">

