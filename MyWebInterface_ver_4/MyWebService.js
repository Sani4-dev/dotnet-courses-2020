function CreateReward(){
	document.getElementById('btnActionReward').innerHTML = "Создать";
	document.getElementById('reward').style.display = 'block';
}

function EditReward(){
	document.getElementById('btnActionReward').innerHTML = "Редактировать";
	document.getElementById('reward').style.display = 'block';
}

function EditUser(){
	document.getElementById('btnActionUser').innerHTML = "Редактировать";
	document.getElementById('user').style.display='block'
}

function CreateUser(){
	document.getElementById('btnActionUser').innerHTML = "Создать";
	document.getElementById('user').style.display='block'
}

function RemoveConfirmation(question){
	result = confirm(question);
}

function myConfigure() {
	document.getElementById("users").style.display = "block";
	tablinks = document.getElementsByClassName("tablinks");
		tablinks[0].className += " active";
}

function openTable(evt, tableName) {
	var i, tabcontent, tablinks;
	tabcontent = document.getElementsByClassName("tabcontent");
	for (i = 0; i < tabcontent.length; i++) {
		tabcontent[i].style.display = "none";
	}
	tablinks = document.getElementsByClassName("tablinks");
	for (i = 0; i < tablinks.length; i++) {
		tablinks[i].className = tablinks[i].className.replace(" active", "");
	}
	document.getElementById(tableName).style.display = "block";
	evt.currentTarget.className += " active";
}
