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

	var availableRewardsBox = document.getElementById('selectRewardsAvailableEdit');
	var rewardsThatUserHaveAtEditMode = document.getElementById('selectRewardsUserEdit');
	var listRewardsNameAvailable = availableRewardsBox.querySelectorAll('option');

	if (listRewardsNameAvailable.length > 0) {
		for (let i = 0; i < listRewardsNameAvailable.length; i++) {
			listRewardsNameAvailable[i].remove();
		}
	}

	var table = document.getElementById('rewards');
	var rowList = table.querySelectorAll('tr');

	if (rowList.length > 2) {
		for (let i = 1; i < rowList.length - 1; i++) {
			var reward = document.createElement('option');

			reward.innerHTML = rowList[i].children[1].innerHTML;
			availableRewardsBox.append(reward);
		}
	}

	var stringWithRewardsSelectedUser = obj.parentNode.parentNode.querySelectorAll('td')[5].innerHTML;
	var listRewardsNameUser = stringWithRewardsSelectedUser.split('<br>');

	listRewardsNameAvailable = availableRewardsBox.querySelectorAll('option');

	let listToRemoveRewards = [];

	for (let i = 0; i < listRewardsNameAvailable.length; i++) {
		for (let j = 0; j < listRewardsNameUser.length; j++) {
			if (listRewardsNameUser[j].includes(listRewardsNameAvailable[i].innerHTML)) {
				listToRemoveRewards.push(listRewardsNameAvailable[i]);
            }
        }
	}

	while (rewardsThatUserHaveAtEditMode.querySelectorAll('option').length > 0) {
		rewardsThatUserHaveAtEditMode.querySelectorAll('option')[0].remove();
    }

	for (let i = 0; i < listToRemoveRewards.length; i++) {
		rewardsThatUserHaveAtEditMode.append(listToRemoveRewards[i]);
	}

	document.getElementById('btnEditUser').innerHTML = "Редактировать";
	document.getElementById('userEdit').style.display = 'block';
}

function CreateUser() {
	var availableRewardsBox = document.getElementById('selectRewardsAvailableCreate');
	var listNameRewards = availableRewardsBox.querySelectorAll('option');

	if (listNameRewards.length > 0) {
		for (let i = 0; i < listNameRewards.length; i++) {
			listNameRewards[i].remove();
        }
    }

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

function AddRewardToUserEdit() {
	var userRewardsBox = document.getElementById('selectRewardsUserEdit');
	var availableRewardsBox = document.getElementById('selectRewardsAvailableEdit');

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

function RemoveRewardToUserEdit() {
	var userRewardsBox = document.getElementById('selectRewardsUserEdit');
	var availableRewardsBox = document.getElementById('selectRewardsAvailableEdit');

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

function HandlerUndoSubmitEdit() {
	var listOptionToSelected = document.getElementById('selectRewardsUserEdit').getElementsByTagName('option');

	for (let i = 0; i < listOptionToSelected.length; i++) {
		listOptionToSelected[i].selected = true;
	}
}

function HandlerUndoSubmitCreate() {
	var listOptionToSelected = document.getElementById('selectRewardsUserCreate').getElementsByTagName('option');

	for (let i = 0; i < listOptionToSelected.length; i++) {
		listOptionToSelected[i].selected = true;
	}
}
