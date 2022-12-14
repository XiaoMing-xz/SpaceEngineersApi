using VRage.Audio;

namespace Sandbox
{
	public static class MyGuiSoundManager
	{
		private static IMyGuiAudio m_audio;

		public static IMyGuiAudio Audio
		{
			set
			{
				m_audio = value;
			}
		}

		public static void PlaySound(GuiSounds sound)
		{
			if (m_audio != null)
			{
				m_audio.PlaySound(sound);
			}
		}
	}
}
