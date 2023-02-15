<?php

namespace App\Models;

use Illuminate\Database\Eloquent\Factories\HasFactory;
use Illuminate\Database\Eloquent\Model;
use App\Models\Employee;
class Department extends Model
{
    use HasFactory;
  //  protected $fillable={};
    public function emps()
    {
        return $this->hasMany(Employee::class);
        //return $this->belongsTo(Employee::class);
    }
}
