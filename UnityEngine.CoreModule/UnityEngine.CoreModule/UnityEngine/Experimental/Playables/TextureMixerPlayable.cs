using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine.Playables;

namespace UnityEngine.Experimental.Playables
{
	// Token: 0x02000167 RID: 359
	[StructLayout(2)]
	public struct TextureMixerPlayable
	{
		// Token: 0x06001AD8 RID: 6872 RVA: 0x0005FBCC File Offset: 0x0005DDCC
		// Note: this type is marked as 'beforefieldinit'.
		static TextureMixerPlayable()
		{
			Il2CppClassPointerStore<TextureMixerPlayable>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Experimental.Playables", "TextureMixerPlayable");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TextureMixerPlayable>.NativeClassPtr);
			TextureMixerPlayable.NativeFieldInfoPtr_m_Handle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextureMixerPlayable>.NativeClassPtr, "m_Handle");
			TextureMixerPlayable.NativeMethodInfoPtr_GetHandle_Public_Virtual_Final_New_PlayableHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextureMixerPlayable>.NativeClassPtr, 100665270);
			TextureMixerPlayable.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_TextureMixerPlayable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextureMixerPlayable>.NativeClassPtr, 100665271);
			TextureMixerPlayable.CreateTextureMixerPlayableInternalDelegateField = IL2CPP.ResolveICall<TextureMixerPlayable.CreateTextureMixerPlayableInternalDelegate>("UnityEngine.Experimental.Playables.TextureMixerPlayable::CreateTextureMixerPlayableInternal");
		}

		// Token: 0x06001AD9 RID: 6873 RVA: 0x0005FC48 File Offset: 0x0005DE48
		[CallerCount(0)]
		public unsafe UnityEngine.Playables.PlayableHandle GetHandle()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextureMixerPlayable.NativeMethodInfoPtr_GetHandle_Public_Virtual_Final_New_PlayableHandle_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001ADA RID: 6874 RVA: 0x0005FC78 File Offset: 0x0005DE78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83143, XrefRangeEnd = 83147, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(TextureMixerPlayable other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextureMixerPlayable.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_TextureMixerPlayable_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001ADB RID: 6875 RVA: 0x0000ECEC File Offset: 0x0000CEEC
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TextureMixerPlayable>.NativeClassPtr, ref this));
		}

		// Token: 0x06001ADC RID: 6876 RVA: 0x0005FCB8 File Offset: 0x0005DEB8
		public static TextureMixerPlayable Create(UnityEngine.Playables.PlayableGraph graph)
		{
			UnityEngine.Playables.PlayableHandle playableHandle = TextureMixerPlayable.CreateHandle(graph);
			return new TextureMixerPlayable(playableHandle);
		}

		// Token: 0x06001ADD RID: 6877 RVA: 0x0005FCD8 File Offset: 0x0005DED8
		public static UnityEngine.Playables.PlayableHandle CreateHandle(UnityEngine.Playables.PlayableGraph graph)
		{
			UnityEngine.Playables.PlayableHandle @null = UnityEngine.Playables.PlayableHandle.Null;
			bool flag = !TextureMixerPlayable.CreateTextureMixerPlayableInternal(ref graph, ref @null);
			UnityEngine.Playables.PlayableHandle playableHandle;
			if (flag)
			{
				playableHandle = UnityEngine.Playables.PlayableHandle.Null;
			}
			else
			{
				playableHandle = @null;
			}
			return playableHandle;
		}

		// Token: 0x06001ADE RID: 6878 RVA: 0x0005FD0C File Offset: 0x0005DF0C
		public static implicit operator UnityEngine.Playables.Playable(TextureMixerPlayable playable)
		{
			return new UnityEngine.Playables.Playable(playable.GetHandle());
		}

		// Token: 0x06001ADF RID: 6879 RVA: 0x0005FD2C File Offset: 0x0005DF2C
		public static explicit operator TextureMixerPlayable(UnityEngine.Playables.Playable playable)
		{
			return new TextureMixerPlayable(playable.GetHandle());
		}

		// Token: 0x06001AE0 RID: 6880 RVA: 0x0000ECFE File Offset: 0x0000CEFE
		public static bool CreateTextureMixerPlayableInternal(ref UnityEngine.Playables.PlayableGraph graph, ref UnityEngine.Playables.PlayableHandle handle)
		{
			return TextureMixerPlayable.CreateTextureMixerPlayableInternalDelegateField(ref graph, ref handle);
		}

		// Token: 0x0400142F RID: 5167
		private static readonly IntPtr NativeFieldInfoPtr_m_Handle;

		// Token: 0x04001430 RID: 5168
		private static readonly IntPtr NativeMethodInfoPtr_GetHandle_Public_Virtual_Final_New_PlayableHandle_0;

		// Token: 0x04001431 RID: 5169
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_TextureMixerPlayable_0;

		// Token: 0x04001432 RID: 5170
		[FieldOffset(0)]
		public UnityEngine.Playables.PlayableHandle m_Handle;

		// Token: 0x04001433 RID: 5171
		private static readonly TextureMixerPlayable.CreateTextureMixerPlayableInternalDelegate CreateTextureMixerPlayableInternalDelegateField;

		// Token: 0x02000A12 RID: 2578
		// (Invoke) Token: 0x0600324A RID: 12874
		private delegate bool CreateTextureMixerPlayableInternalDelegate(IntPtr graph, IntPtr handle);
	}
}
