﻿using Publisher.Models;

namespace Publisher.DTO.ResponseDTO;

public class PostResponseDto
{
	public long Id { get; set; }
	public long IssueId { get; set; }
	public Issue Issue { get; set; }
	public string Content { get; set; }
}