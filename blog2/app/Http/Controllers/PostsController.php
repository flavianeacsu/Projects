<?php

namespace App\Http\Controllers;

use Illuminate\Http\Request;
use App\Post;

class PostsController extends Controller
{
    public function __construct()
    {
        $this->middleware('auth')->except(['index','show']);
    }

    public function index()
    {
    	$posts = Post::latest()->get();
    	// $posts = Post::orderBy('created_at', 'asc')->get()
    	return view('posts.index', compact('posts'));
    }

    public function show(Post $post)
    {
    	//$post = Post::find($id);
    	return view('posts.show', compact('post'));
    }

    public function create()
    {
    	return view('posts.create');
    }

    public function store()
    {
    	//create a new post using the request data
    	// save it to the database
    	//redirect to the home page
    	// dd = die and dump
    	//dd(request()->all());
    	//dd(request(['title','body']));

    	/*$post = new Post;

    	$post->title = request('title');
    	$post->body = request('body');

    	$post->save();*/

    	$this->validate(request(),[
    		'title' => 'required',
    		'body' => 'required'
    	]);

        auth()->user()->publish(
            new Post(request(['title','body']))
        );

    	/*Post::create([
    		'title' => request('title'),
    		'body' => request('body'),
            'user_id' => auth()->id()
    	]);*/

    	return redirect('/');
    }
}
