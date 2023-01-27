<?php

use Illuminate\Support\Facades\Route;

/*
|--------------------------------------------------------------------------
| Web Routes
|--------------------------------------------------------------------------
|
| Here is where you can register web routes for your application. These
| routes are loaded by the RouteServiceProvider within a group which
| contains the "web" middleware group. Now create something great!
|
*/

Route::resource('/std',App\Http\Controllers\StudentController::class);

// Route::get('/', function () {
//      return view('welcome');
//     echo "ok";
// });

// Route::post('/', function (Request $req) {
//     // return view('welcome');
    
//     $data = $req->all();
//     var_dump($data);
//     echo "Post Route";
// });

// Route::put('/update', function () {
//     // return view('welcome');
//     $data = Request::all();
//     var_dump($data);
//     echo "Post Route";
// });

// Route::get('/{id}', function ($id) {
//     // return view('welcome');
//     echo "Required Parameter".$id;
// });

// Route::get('/test/{id?}', function ($id=2) {
//     // return view('welcome');
//     echo "Optional Parameter".$id;
// });

// Route::get('/{page}/{id}', function ($page,$id) {
//     // return view('welcome');
//     # /product/1
//     echo $page.':'.$id;
// });
// Route::get('/dum/{page}/{id?}', function ($page,$id=null) {
//     // return view('welcome');
//     # /product/1
//     echo $page.':';
// });
