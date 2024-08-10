<?php

namespace Database\Seeders;

use Illuminate\Database\Console\Seeds\WithoutModelEvents;
use Illuminate\Database\Seeder;
use App\Models\User;
class UserSeeder extends Seeder
{
    /**
     * Run the database seeds.
     */
    public function run(): void
    {
        //
        User::Create([
            'name'=>'Admin Account',
            'email'=>'admin@gmail.com',
            'password'=>'123'

        ]);
        User::Create([
            'name'=>'User Account',
            'email'=>'user@gmail.com',
            'password'=>'123'

        ]);
    }
    
}
