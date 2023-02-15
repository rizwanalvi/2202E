<?php

namespace App\Models;

use Illuminate\Database\Eloquent\Factories\HasFactory;
use Illuminate\Database\Eloquent\Model;
use App\Models\Department;

class Employee extends Model
{
    use HasFactory;
    public function dept()
    {
        return $this->belongsTo(Department::class);
        //return $this->hasMany(Department::class);
    }
}
