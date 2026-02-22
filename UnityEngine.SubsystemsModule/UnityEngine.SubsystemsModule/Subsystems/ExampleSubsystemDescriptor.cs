using System;
using Il2CppInterop.Runtime;

namespace UnityEngine.Subsystems
{
	// Token: 0x02000013 RID: 19
	public class ExampleSubsystemDescriptor : IntegratedSubsystemDescriptor<ExampleSubsystem>
	{
		// Token: 0x1700001E RID: 30
		// (get) Token: 0x0600008B RID: 139 RVA: 0x000025B3 File Offset: 0x000007B3
		public bool supportsEditorMode
		{
			get
			{
				return ExampleSubsystemDescriptor.get_supportsEditorModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x0600008C RID: 140 RVA: 0x000025C5 File Offset: 0x000007C5
		public bool disableBackbufferMSAA
		{
			get
			{
				return ExampleSubsystemDescriptor.get_disableBackbufferMSAADelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x0600008D RID: 141 RVA: 0x000025D7 File Offset: 0x000007D7
		public bool stereoscopicBackbuffer
		{
			get
			{
				return ExampleSubsystemDescriptor.get_stereoscopicBackbufferDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x0600008E RID: 142 RVA: 0x000025E9 File Offset: 0x000007E9
		public bool usePBufferEGL
		{
			get
			{
				return ExampleSubsystemDescriptor.get_usePBufferEGLDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x04000032 RID: 50
		private static readonly ExampleSubsystemDescriptor.get_supportsEditorModeDelegate get_supportsEditorModeDelegateField = IL2CPP.ResolveICall<ExampleSubsystemDescriptor.get_supportsEditorModeDelegate>("UnityEngine.Subsystems.ExampleSubsystemDescriptor::get_supportsEditorMode");

		// Token: 0x04000033 RID: 51
		private static readonly ExampleSubsystemDescriptor.get_disableBackbufferMSAADelegate get_disableBackbufferMSAADelegateField = IL2CPP.ResolveICall<ExampleSubsystemDescriptor.get_disableBackbufferMSAADelegate>("UnityEngine.Subsystems.ExampleSubsystemDescriptor::get_disableBackbufferMSAA");

		// Token: 0x04000034 RID: 52
		private static readonly ExampleSubsystemDescriptor.get_stereoscopicBackbufferDelegate get_stereoscopicBackbufferDelegateField = IL2CPP.ResolveICall<ExampleSubsystemDescriptor.get_stereoscopicBackbufferDelegate>("UnityEngine.Subsystems.ExampleSubsystemDescriptor::get_stereoscopicBackbuffer");

		// Token: 0x04000035 RID: 53
		private static readonly ExampleSubsystemDescriptor.get_usePBufferEGLDelegate get_usePBufferEGLDelegateField = IL2CPP.ResolveICall<ExampleSubsystemDescriptor.get_usePBufferEGLDelegate>("UnityEngine.Subsystems.ExampleSubsystemDescriptor::get_usePBufferEGL");

		// Token: 0x02000020 RID: 32
		// (Invoke) Token: 0x060000A2 RID: 162
		private delegate bool get_supportsEditorModeDelegate(IntPtr @this);

		// Token: 0x02000021 RID: 33
		// (Invoke) Token: 0x060000A4 RID: 164
		private delegate bool get_disableBackbufferMSAADelegate(IntPtr @this);

		// Token: 0x02000022 RID: 34
		// (Invoke) Token: 0x060000A6 RID: 166
		private delegate bool get_stereoscopicBackbufferDelegate(IntPtr @this);

		// Token: 0x02000023 RID: 35
		// (Invoke) Token: 0x060000A8 RID: 168
		private delegate bool get_usePBufferEGLDelegate(IntPtr @this);
	}
}
