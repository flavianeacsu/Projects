<?php

namespace App;

class Comment extends Model
{
    // $comment->post;
    public function post()
    {
    	return $this->belongsTo(Post::class);
    }

    public function user()
    {
    	//a comment belongs to a user
    	return $this->belongsTo(User::class);
    }
}
