using System;
namespace PsychologicalTesting.Services.ClipboardServiceNS
{
	public interface IClipboardService
	{
		Task CopyToClipboard(string text);
	}
}

