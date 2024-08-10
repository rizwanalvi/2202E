<?php

namespace Database\Seeders;

use Illuminate\Database\Console\Seeds\WithoutModelEvents;
use Illuminate\Database\Seeder;
use App\Models\Course;

class CourseSeeder extends Seeder
{
    /**
     * Run the database seeds.
     */
    public function run(): void
    {
        //
        Course::create([
            'coursename'=>'Java Script',
            'code'=>'Js04'
        ]);
        Course::create([
            'coursename'=>'C# programming',
            'code'=>'C#02'
        ]);
        Course::create([
            'coursename'=>'Java Web Development',
            'code'=>'JW04'
        ]);
    }
}
