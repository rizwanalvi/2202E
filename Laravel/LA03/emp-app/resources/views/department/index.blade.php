<link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@4.6.2/dist/css/bootstrap.min.css" integrity="sha384-xOolHFLEh07PJGoPkLv1IbcEPTNtaed2xpHsD9ESMhqIYd0nLMwNLD69Npy4HI+N" crossorigin="anonymous">
<h1>Index</h1>
<div class="form-group">
<a href="/dept/create" class='btn btn-primary btn-sm'>Create</a>
</div>




<table class="table">
  <thead class="thead-dark">
    <tr>
      <th scope="col">S.NO</th>
      <th scope="col">Department Name</th>
      <th scope="col">Department Code</th>
      <th scope="col">Handle</th>
    </tr>
  </thead>
  <tbody>
  @foreach($data as $item)
   
    <tr>
      <th scope="row"> {{$item->id}}</th>
      <td> {{$item->dept_name}}</td>
      <td> {{$item->code}}</td>
      <td><div class="btn-group">
    <a href="/dept/{{$item->id}}" class='btn btn-warning btn-sm'>Show</a>
    <a href="/ dept/{{$item->id}}/edit" class='btn btn-success btn-sm'>Edit</a>
    
    <a href="/dept/{{$item->id}}" class='btn btn-danger btn-sm'>Delete</a>
</div></td>
    </tr>
@endforeach
   
    </tbody>
</table>

