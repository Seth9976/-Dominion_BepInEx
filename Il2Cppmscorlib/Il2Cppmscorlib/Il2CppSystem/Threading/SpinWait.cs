using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Threading
{
	// Token: 0x02000262 RID: 610
	[StructLayout(2)]
	public struct SpinWait
	{
		// Token: 0x06002A6C RID: 10860 RVA: 0x000DB170 File Offset: 0x000D9370
		// Note: this type is marked as 'beforefieldinit'.
		static SpinWait()
		{
			Il2CppClassPointerStore<SpinWait>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading", "SpinWait");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpinWait>.NativeClassPtr);
			SpinWait.NativeFieldInfoPtr_m_count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpinWait>.NativeClassPtr, "m_count");
			SpinWait.NativeMethodInfoPtr_get_NextSpinWillYield_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpinWait>.NativeClassPtr, 100670049);
			SpinWait.NativeMethodInfoPtr_SpinOnce_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpinWait>.NativeClassPtr, 100670050);
		}

		// Token: 0x17000A12 RID: 2578
		// (get) Token: 0x06002A6D RID: 10861 RVA: 0x000DB1DC File Offset: 0x000D93DC
		public unsafe bool NextSpinWillYield
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 331141, RefRangeEnd = 331142, XrefRangeStart = 331141, XrefRangeEnd = 331141, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpinWait.NativeMethodInfoPtr_get_NextSpinWillYield_Public_get_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002A6E RID: 10862 RVA: 0x000DB20C File Offset: 0x000D940C
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 331149, RefRangeEnd = 331162, XrefRangeStart = 331142, XrefRangeEnd = 331149, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SpinOnce()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpinWait.NativeMethodInfoPtr_SpinOnce_Public_Void_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002A6F RID: 10863 RVA: 0x0000ECB5 File Offset: 0x0000CEB5
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SpinWait>.NativeClassPtr, ref this));
		}

		// Token: 0x04002533 RID: 9523
		private static readonly IntPtr NativeFieldInfoPtr_m_count;

		// Token: 0x04002534 RID: 9524
		private static readonly IntPtr NativeMethodInfoPtr_get_NextSpinWillYield_Public_get_Boolean_0;

		// Token: 0x04002535 RID: 9525
		private static readonly IntPtr NativeMethodInfoPtr_SpinOnce_Public_Void_0;

		// Token: 0x04002536 RID: 9526
		[FieldOffset(0)]
		public int m_count;
	}
}
