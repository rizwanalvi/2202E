<h1>WELLCOME</h1>
<form action="/" method="post">
    @csrf
    <!-- @method('put') -->
    <input type="text" name="txtName">
    <input type="number" name="txtAge">
    <input type="submit" value="Save">
</form>