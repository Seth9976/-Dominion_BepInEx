using System;
using Il2CppInterop.Runtime;

namespace UnityEngine.Subsystems
{
	// Token: 0x02000012 RID: 18
	public class ExampleSubsystem : IntegratedSubsystem<ExampleSubsystemDescriptor>
	{
		// Token: 0x06000088 RID: 136 RVA: 0x00002551 File Offset: 0x00000751
		public void PrintExample()
		{
			ExampleSubsystem.PrintExampleDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x06000089 RID: 137 RVA: 0x00002563 File Offset: 0x00000763
		public bool GetBool()
		{
			return ExampleSubsystem.GetBoolDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x04000030 RID: 48
		private static readonly ExampleSubsystem.PrintExampleDelegate PrintExampleDelegateField = IL2CPP.ResolveICall<ExampleSubsystem.PrintExampleDelegate>("UnityEngine.Subsystems.ExampleSubsystem::PrintExample");

		// Token: 0x04000031 RID: 49
		private static readonly ExampleSubsystem.GetBoolDelegate GetBoolDelegateField = IL2CPP.ResolveICall<ExampleSubsystem.GetBoolDelegate>("UnityEngine.Subsystems.ExampleSubsystem::GetBool");

		// Token: 0x0200001E RID: 30
		// (Invoke) Token: 0x0600009E RID: 158
		private delegate void PrintExampleDelegate(IntPtr @this);

		// Token: 0x0200001F RID: 31
		// (Invoke) Token: 0x060000A0 RID: 160
		private delegate bool GetBoolDelegate(IntPtr @this);
	}
}
