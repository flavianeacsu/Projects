@extends ('layout')

@section ('content')
	<div class="col-sm-8 blog-main">
		<h1>Create a post</h1>
		<form method="POST" action="/posts">
			{{csrf_field()}} <!-- security, INCLUDE FOR ALL FORMS  unique token-->
		  <div class="form-group">
		    <label for="title">Title</label>
		    <input type="title" class="form-control" id="title" name="title">
		  </div>

		  <div class="form-group">
		    <label for="exampleInputPassword1">Body</label>
		    <textarea id="body" name="body" class="form-control"></textarea>
		  </div>
		 
		  <div class="form-group">
		  	<button type="submit" class="btn btn-primary">Publish</button>
		  </div>

		  @include('layouts.errors')
		</form>


	</div>
@endsection