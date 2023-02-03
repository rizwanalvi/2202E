<link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@4.6.2/dist/css/bootstrap.min.css" integrity="sha384-xOolHFLEh07PJGoPkLv1IbcEPTNtaed2xpHsD9ESMhqIYd0nLMwNLD69Npy4HI+N" crossorigin="anonymous">
<form action="/dept" method="post">
    @csrf
    <input type="text" name="dept_name">
    <input type="text" name="code">
    <input type="submit" name="btnSave" value="Save">
</form>