<form action="/gal" method="post" enctype="multipart/form-data">
    @csrf
    <input type="file" name="img">
    <input type="submit" value="Save">
</form>