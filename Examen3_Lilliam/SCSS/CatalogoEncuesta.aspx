<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CatalogoEncuesta.aspx.cs" Inherits="Examen3_Lilliam.SCSS.CatalogoEncuesta" %>

<!DOCTYPE html>
<html>
<body>

<h2>Formulario de Encuesta</h2>

<form action="/submit_encuesta" method="post">
  <label for="nombre">Nombre:</label><br>
  <input type="text" id="nombre" name="nombre" required><br>
  <label for="edad">Edad:</label><br>
  <input type="number" id="edad" name="edad" min="18" max="50" required><br>
  <label for="correo">Correo Electrónico:</label><br>
  <input type="email" id="correo" name="correo" required><br>
  <label for="partido">Partido Político:</label><br>
  <select id="partido" name="partido" required>
    <option value="PLN">PLN</option>
    <option value="PUSC">PUSC</option>
    <option value="PAC">PAC</option>
  </select><br>
  <input type="submit" value="Submit">
</form> 

</body>
</html>