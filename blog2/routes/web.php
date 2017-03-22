<?php



Route::get('/', 'PostsController@index')->name('home');
Route::get('/posts/create','PostsController@create');
Route::post('/posts','PostsController@store');
Route::get('/posts/{post}', 'PostsController@show');

Route::post('/posts/{post}/comments','CommentsController@store');

Route::get('/register','RegistrationController@create');
Route::post('/register','RegistrationController@store');
Route::get('/login','SessionsController@create');
Route::post('/login','SessionsController@store');
Route::get('/logout','SessionsController@destroy');


//GET /posts -> toate
//GET /posts/create
//POST /posts ->storing a new one in a database
//GET /posts/{id}/edit => PATCH /posts/{id}
//GET /posts/{id}
//DELETE /posts/{id}
//Auth::routes();

//Route::get('/home', 'HomeController@index');
