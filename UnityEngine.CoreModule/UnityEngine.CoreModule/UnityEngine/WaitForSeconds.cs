using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine
{
	// Token: 0x020000C9 RID: 201
	public sealed class WaitForSeconds : YieldInstruction
	{
		// Token: 0x06001185 RID: 4485 RVA: 0x000472D0 File Offset: 0x000454D0
		// Note: this type is marked as 'beforefieldinit'.
		static WaitForSeconds()
		{
			Il2CppClassPointerStore<WaitForSeconds>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "WaitForSeconds");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WaitForSeconds>.NativeClassPtr);
			WaitForSeconds.NativeFieldInfoPtr_m_Seconds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaitForSeconds>.NativeClassPtr, "m_Seconds");
			WaitForSeconds.NativeMethodInfoPtr__ctor_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitForSeconds>.NativeClassPtr, 100664531);
		}

		// Token: 0x06001186 RID: 4486 RVA: 0x00047328 File Offset: 0x00045528
		[CallerCount(35)]
		[CachedScanResults(RefRangeStart = 76604, RefRangeEnd = 76639, XrefRangeStart = 76603, XrefRangeEnd = 76604, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WaitForSeconds(float seconds)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WaitForSeconds>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref seconds;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaitForSeconds.NativeMethodInfoPtr__ctor_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001187 RID: 4487 RVA: 0x0000A7BC File Offset: 0x000089BC
		public WaitForSeconds(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700038E RID: 910
		// (get) Token: 0x06001188 RID: 4488 RVA: 0x00047370 File Offset: 0x00045570
		// (set) Token: 0x06001189 RID: 4489 RVA: 0x0000A7C5 File Offset: 0x000089C5
		public unsafe float m_Seconds
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaitForSeconds.NativeFieldInfoPtr_m_Seconds);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaitForSeconds.NativeFieldInfoPtr_m_Seconds)) = value;
			}
		}

		// Token: 0x04000D30 RID: 3376
		private static readonly IntPtr NativeFieldInfoPtr_m_Seconds;

		// Token: 0x04000D31 RID: 3377
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_0;
	}
}
