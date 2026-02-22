using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Playables
{
	// Token: 0x02000154 RID: 340
	[StructLayout(2)]
	public struct ScriptPlayableOutput
	{
		// Token: 0x06001A6D RID: 6765 RVA: 0x0000EAB6 File Offset: 0x0000CCB6
		// Note: this type is marked as 'beforefieldinit'.
		static ScriptPlayableOutput()
		{
			Il2CppClassPointerStore<ScriptPlayableOutput>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Playables", "ScriptPlayableOutput");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScriptPlayableOutput>.NativeClassPtr);
			ScriptPlayableOutput.NativeFieldInfoPtr_m_Handle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptPlayableOutput>.NativeClassPtr, "m_Handle");
		}

		// Token: 0x06001A6E RID: 6766 RVA: 0x0000EAEF File Offset: 0x0000CCEF
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ScriptPlayableOutput>.NativeClassPtr, ref this));
		}

		// Token: 0x06001A6F RID: 6767 RVA: 0x0005E2A0 File Offset: 0x0005C4A0
		public static ScriptPlayableOutput Create(PlayableGraph graph, string name)
		{
			PlayableOutputHandle playableOutputHandle;
			bool flag = !graph.CreateScriptOutputInternal(name, out playableOutputHandle);
			ScriptPlayableOutput scriptPlayableOutput;
			if (flag)
			{
				scriptPlayableOutput = ScriptPlayableOutput.Null;
			}
			else
			{
				scriptPlayableOutput = new ScriptPlayableOutput(playableOutputHandle);
			}
			return scriptPlayableOutput;
		}

		// Token: 0x170005A8 RID: 1448
		// (get) Token: 0x06001A70 RID: 6768 RVA: 0x0005E2D4 File Offset: 0x0005C4D4
		public static ScriptPlayableOutput Null
		{
			get
			{
				return new ScriptPlayableOutput(PlayableOutputHandle.Null);
			}
		}

		// Token: 0x06001A71 RID: 6769 RVA: 0x0005E2F0 File Offset: 0x0005C4F0
		public PlayableOutputHandle GetHandle()
		{
			return this.m_Handle;
		}

		// Token: 0x06001A72 RID: 6770 RVA: 0x0005E308 File Offset: 0x0005C508
		public static implicit operator PlayableOutput(ScriptPlayableOutput output)
		{
			return new PlayableOutput(output.GetHandle());
		}

		// Token: 0x06001A73 RID: 6771 RVA: 0x0005E328 File Offset: 0x0005C528
		public static explicit operator ScriptPlayableOutput(PlayableOutput output)
		{
			return new ScriptPlayableOutput(output.GetHandle());
		}

		// Token: 0x0400132E RID: 4910
		private static readonly IntPtr NativeFieldInfoPtr_m_Handle;

		// Token: 0x0400132F RID: 4911
		[FieldOffset(0)]
		public PlayableOutputHandle m_Handle;
	}
}
