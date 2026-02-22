using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.Playables;

namespace UnityEngine.Experimental.Playables
{
	// Token: 0x02000168 RID: 360
	[StructLayout(2)]
	public struct TexturePlayableOutput
	{
		// Token: 0x06001AE1 RID: 6881 RVA: 0x0005FD4C File Offset: 0x0005DF4C
		// Note: this type is marked as 'beforefieldinit'.
		static TexturePlayableOutput()
		{
			Il2CppClassPointerStore<TexturePlayableOutput>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Experimental.Playables", "TexturePlayableOutput");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TexturePlayableOutput>.NativeClassPtr);
			TexturePlayableOutput.NativeFieldInfoPtr_m_Handle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TexturePlayableOutput>.NativeClassPtr, "m_Handle");
			TexturePlayableOutput.InternalGetTargetDelegateField = IL2CPP.ResolveICall<TexturePlayableOutput.InternalGetTargetDelegate>("UnityEngine.Experimental.Playables.TexturePlayableOutput::InternalGetTarget");
			TexturePlayableOutput.InternalSetTargetDelegateField = IL2CPP.ResolveICall<TexturePlayableOutput.InternalSetTargetDelegate>("UnityEngine.Experimental.Playables.TexturePlayableOutput::InternalSetTarget");
		}

		// Token: 0x06001AE2 RID: 6882 RVA: 0x0000ED0C File Offset: 0x0000CF0C
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TexturePlayableOutput>.NativeClassPtr, ref this));
		}

		// Token: 0x06001AE3 RID: 6883 RVA: 0x0005FDB0 File Offset: 0x0005DFB0
		public static TexturePlayableOutput Create(UnityEngine.Playables.PlayableGraph graph, string name, RenderTexture target)
		{
			UnityEngine.Playables.PlayableOutputHandle playableOutputHandle;
			bool flag = !TexturePlayableGraphExtensions.InternalCreateTextureOutput(ref graph, name, out playableOutputHandle);
			TexturePlayableOutput texturePlayableOutput;
			if (flag)
			{
				texturePlayableOutput = TexturePlayableOutput.Null;
			}
			else
			{
				TexturePlayableOutput texturePlayableOutput2 = new TexturePlayableOutput(playableOutputHandle);
				texturePlayableOutput2.SetTarget(target);
				texturePlayableOutput = texturePlayableOutput2;
			}
			return texturePlayableOutput;
		}

		// Token: 0x170005AF RID: 1455
		// (get) Token: 0x06001AE4 RID: 6884 RVA: 0x0005FDF0 File Offset: 0x0005DFF0
		public static TexturePlayableOutput Null
		{
			get
			{
				return new TexturePlayableOutput(UnityEngine.Playables.PlayableOutputHandle.Null);
			}
		}

		// Token: 0x06001AE5 RID: 6885 RVA: 0x0005FE0C File Offset: 0x0005E00C
		public UnityEngine.Playables.PlayableOutputHandle GetHandle()
		{
			return this.m_Handle;
		}

		// Token: 0x06001AE6 RID: 6886 RVA: 0x0005FE24 File Offset: 0x0005E024
		public static implicit operator UnityEngine.Playables.PlayableOutput(TexturePlayableOutput output)
		{
			return new UnityEngine.Playables.PlayableOutput(output.GetHandle());
		}

		// Token: 0x06001AE7 RID: 6887 RVA: 0x0005FE44 File Offset: 0x0005E044
		public static explicit operator TexturePlayableOutput(UnityEngine.Playables.PlayableOutput output)
		{
			return new TexturePlayableOutput(output.GetHandle());
		}

		// Token: 0x06001AE8 RID: 6888 RVA: 0x0005FE64 File Offset: 0x0005E064
		public RenderTexture GetTarget()
		{
			return TexturePlayableOutput.InternalGetTarget(ref this.m_Handle);
		}

		// Token: 0x06001AE9 RID: 6889 RVA: 0x0000ED1E File Offset: 0x0000CF1E
		public void SetTarget(RenderTexture value)
		{
			TexturePlayableOutput.InternalSetTarget(ref this.m_Handle, value);
		}

		// Token: 0x06001AEA RID: 6890 RVA: 0x0005FE84 File Offset: 0x0005E084
		public static RenderTexture InternalGetTarget(ref UnityEngine.Playables.PlayableOutputHandle output)
		{
			IntPtr intPtr = TexturePlayableOutput.InternalGetTargetDelegateField(ref output);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<RenderTexture>(intPtr2) : null;
		}

		// Token: 0x06001AEB RID: 6891 RVA: 0x0000ED2E File Offset: 0x0000CF2E
		public static void InternalSetTarget(ref UnityEngine.Playables.PlayableOutputHandle output, RenderTexture target)
		{
			TexturePlayableOutput.InternalSetTargetDelegateField(ref output, IL2CPP.Il2CppObjectBaseToPtr(target));
		}

		// Token: 0x04001434 RID: 5172
		private static readonly IntPtr NativeFieldInfoPtr_m_Handle;

		// Token: 0x04001435 RID: 5173
		[FieldOffset(0)]
		public UnityEngine.Playables.PlayableOutputHandle m_Handle;

		// Token: 0x04001436 RID: 5174
		private static readonly TexturePlayableOutput.InternalGetTargetDelegate InternalGetTargetDelegateField;

		// Token: 0x04001437 RID: 5175
		private static readonly TexturePlayableOutput.InternalSetTargetDelegate InternalSetTargetDelegateField;

		// Token: 0x02000A13 RID: 2579
		// (Invoke) Token: 0x0600324C RID: 12876
		private delegate IntPtr InternalGetTargetDelegate(IntPtr output);

		// Token: 0x02000A14 RID: 2580
		// (Invoke) Token: 0x0600324E RID: 12878
		private delegate void InternalSetTargetDelegate(IntPtr output, IntPtr target);
	}
}
