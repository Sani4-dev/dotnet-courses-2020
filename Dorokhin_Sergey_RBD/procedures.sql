CREATE PROCEDURE AddUser
	@firstName VARCHAR(50),
	@lastName VARCHAR(50),
	@birthday DATE,
	@rewardIds RewardsIds READONLY
AS
BEGIN
	DECLARE @userId AS TABLE(id INT)

	INSERT INTO Users
	OUTPUT Inserted.Id INTO @userId
	VALUES(@firstName, @lastName, @birthday)

	INSERT INTO Relations
	SELECT [@userId].Id, [@rewardIds].Id FROM @userId, @rewardIds
END
GO

CREATE PROCEDURE UpdateUser
	@userId INT,
	@firstName VARCHAR(50),
	@lastName VARCHAR(50),
	@birthday DATE,
	@rewardIds RewardsIds READONLY
AS
BEGIN
	UPDATE Users
	SET Users.FirstName = @firstName, Users.LastName = @lastName, Users.Birthday = @birthday
	WHERE Users.Id = @userId

	DELETE FROM Relations
	WHERE Relations.UserId = @userId

	INSERT INTO Relations
	SELECT @userId, [@rewardIds].Id FROM @rewardIds
END
GO

CREATE PROCEDURE RemoveUser
	@userId INT
AS
BEGIN
	DELETE FROM Users
	WHERE Users.Id = @userId
END
GO

CREATE PROCEDURE AddReward
	@title VARCHAR(50),
	@description VARCHAR(250)
AS
BEGIN
	INSERT INTO Rewards
	VALUES(@title, @description)
END
GO

CREATE PROCEDURE UpdateReward
	@rewardId INT,
	@title VARCHAR(50),
	@description VARCHAR(250)
AS
BEGIN
	UPDATE Rewards
	SET Rewards.Title = @title, Rewards.Description = @description
	WHERE Rewards.Id = @rewardId
END
GO

CREATE PROCEDURE RemoveReward
	@rewardId INT
AS
BEGIN
	DELETE Rewards
	WHERE Rewards.Id = @rewardId
END
GO

CREATE PROCEDURE GetAllRewardsCurrentUser
	@userId INT
AS
BEGIN
	SELECT Rewards.Title
	FROM Rewards
	JOIN Relations ON Relations.RewardId = Rewards.Id
	WHERE Relations.UserId = @userId
END