<h1>Adauga</h1>

<form method="POST" action="/add">
			
	{{ csrf_field() }}
			
		
	<label for="name">Name:</label>
	<input type="text" id="name" name="name" required>

	<br>
			
	<label for="description">Description:</label>
	<input type="text" id="description" name="description" required>

	<br>
	
	<label for="producer">Producer:</label>
	<select name="producer">
		@foreach($producers as $producer)
			<option value="{{$producer->name}}">{{$producer->name}}</option>
		@endforeach
	</select>

	<br>		
	<button type="submit" class="btn btn-primary">Adauga produs</button>

	@if (count($errors))

		<ul>
							
			@foreach($errors->all() as $error)
				<li>{{ $error }}</li>
			@endforeach

		</ul>

	@endif

	<table>
		<tr>
			<th>Denumire</th>
			<th>Descriere</th>
			<th>Producator</th>
			<th>Data</th>
		</tr>
		@foreach($products as $product)
			<tr>
				<td>{{ $product->name}}</td>
				<td>{{ $product->description}}</td>
				<td>{{ App\Producer::find($product->producer_id)->name}}</td>
				<td>{{ $product->created_at->toFormattedDateString()}}</td>
			</tr>
		@endforeach
	</table>
			
</form>