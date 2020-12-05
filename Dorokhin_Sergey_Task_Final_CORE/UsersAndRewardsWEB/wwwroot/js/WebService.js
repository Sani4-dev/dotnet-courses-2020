function CreateReward(){
	document.getElementById('btnCreateReward').innerHTML = "Создать";
	document.getElementById('reward').style.display = 'block';
}

function EditReward(obj) {
	document.getElementById("rewardId").value = obj.parentNode.parentNode.querySelectorAll('td')[0].innerHTML;
	document.getElementById("rewardTitte").value = obj.parentNode.parentNode.querySelectorAll('td')[1].innerHTML;
	document.getElementById("rewardDescription").value = obj.parentNode.parentNode.querySelectorAll('td')[2].innerHTML;
	document.getElementById('btnEditReward').innerHTML = "Редактировать";
	document.getElementById('rewardEdit').style.display = 'block';
}

function EditUser(obj) {
	document.getElementById("userId").value = obj.parentNode.parentNode.querySelectorAll('td')[0].innerHTML;
	document.getElementById("userFirstName").value = obj.parentNode.parentNode.querySelectorAll('td')[1].innerHTML;
	document.getElementById("userLastName").value = obj.parentNode.parentNode.querySelectorAll('td')[2].innerHTML;
	document.getElementById("datep_2").value = obj.parentNode.parentNode.querySelectorAll('td')[3].innerHTML;
	document.getElementById('btnEditUser').innerHTML = "Редактировать";
	document.getElementById('userEdit').style.display = 'block';
}

function CreateUser() {
	var availableRewardsBox = document.getElementById('selectRewardsAvailableCreate');

	var table = document.getElementById('rewards');
	var rowList = table.querySelectorAll('tr');

	if (rowList.length > 2) {
		for (let i = 1; i < rowList.length - 1; i++) {
			var reward = document.createElement('option');

			reward.innerHTML = rowList[i].children[1].innerHTML;
			availableRewardsBox.append(reward);
		}
	}

	document.getElementById('btnCreateUser').innerHTML = "Создать";
	document.getElementById('user').style.display = 'block';
}

function RemoveUserConfirmation(obj) {
	var result = confirm('Вы точно желаете удалить пользователя?');
	if (result) {
		document.getElementById('useIdToRemove').value = obj.parentNode.parentNode.querySelectorAll('td')[0].innerHTML;
		document.forms['userRemoveForm'].submit();
		//fetch('https://localhost:44380/Home/RemoveUser', {
			//method: 'POST',
			//headers: {
				//'Content-Type': 'application/x-www-form-urlencoded'
			//},
			//body: "userIdToRemove=" + obj.parentNode.parentNode.querySelectorAll('td')[0].innerHTML,
		//});
	}
}

function RemoveRewardConfirmation(obj) {
	var result = confirm('Вы точно желаете удалить награду?');
	if (result) {
		document.getElementById('rewIdToRemove').value = obj.parentNode.parentNode.querySelectorAll('td')[0].innerHTML;
		document.forms['rewardRemoveForm'].submit();
		//fetch('https://localhost:44380/Home/RemoveReward', {
			//method: 'POST',
			//headers: {
				//'Content-Type': 'application/x-www-form-urlencoded'
			//},
			//body: "rewardIdToRemove=" + obj.parentNode.parentNode.querySelectorAll('td')[0].innerHTML,
		//});
    }
}

function AddRewardToUserCreation() {
	var userRewardsBox = document.getElementById('selectRewardsUserCreate');
	var availableRewardsBox = document.getElementById('selectRewardsAvailableCreate');

	for (let elem of availableRewardsBox.children) {
		if (elem.innerHTML == availableRewardsBox.value) {
			userRewardsBox.append(elem);
		}
	}
}

function RemoveRewardToUserCreation() {
	var userRewardsBox = document.getElementById('selectRewardsUserCreate');
	var availableRewardsBox = document.getElementById('selectRewardsAvailableCreate');

	for (let elem of userRewardsBox.children) {
		if (elem.innerHTML == userRewardsBox.value) {
			availableRewardsBox.append(elem);
		}
	}
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
