<?php

use Illuminate\Support\Facades\Route;
use App\Models\Department;
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

Route::get('/', function () {
    Department::create(['dept_name'=>'Human Resource',
    'code'=>'HR']);
//    / return view('welcome');
});
