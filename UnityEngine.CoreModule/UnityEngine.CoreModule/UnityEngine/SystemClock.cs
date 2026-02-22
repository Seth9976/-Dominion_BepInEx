using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x020000D6 RID: 214
	public class SystemClock : Object
	{
		// Token: 0x060012AC RID: 4780 RVA: 0x00048DC4 File Offset: 0x00046FC4
		// Note: this type is marked as 'beforefieldinit'.
		static SystemClock()
		{
			Il2CppClassPointerStore<SystemClock>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "SystemClock");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SystemClock>.NativeClassPtr);
			SystemClock.NativeFieldInfoPtr_s_Epoch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SystemClock>.NativeClassPtr, "s_Epoch");
			SystemClock.NativeMethodInfoPtr_get_now_Public_Static_get_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemClock>.NativeClassPtr, 100664564);
		}

		// Token: 0x170003F0 RID: 1008
		// (get) Token: 0x060012AD RID: 4781 RVA: 0x00048E1C File Offset: 0x0004701C
		public unsafe static DateTime now
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 76707, RefRangeEnd = 76709, XrefRangeStart = 76703, XrefRangeEnd = 76707, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemClock.NativeMethodInfoPtr_get_now_Public_Static_get_DateTime_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060012AE RID: 4782 RVA: 0x0000B1F6 File Offset: 0x000093F6
		public SystemClock(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003EF RID: 1007
		// (get) Token: 0x060012AF RID: 4783 RVA: 0x00048E4C File Offset: 0x0004704C
		// (set) Token: 0x060012B0 RID: 4784 RVA: 0x0000B1FF File Offset: 0x000093FF
		public unsafe static DateTime s_Epoch
		{
			get
			{
				DateTime dateTime;
				IL2CPP.il2cpp_field_static_get_value(SystemClock.NativeFieldInfoPtr_s_Epoch, (void*)(&dateTime));
				return dateTime;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SystemClock.NativeFieldInfoPtr_s_Epoch, (void*)(&value));
			}
		}

		// Token: 0x060012B1 RID: 4785 RVA: 0x00048E68 File Offset: 0x00047068
		public static long ToUnixTimeMilliseconds(DateTime date)
		{
			return Convert.ToInt64((date.ToUniversalTime() - SystemClock.s_Epoch).TotalMilliseconds);
		}

		// Token: 0x060012B2 RID: 4786 RVA: 0x00048E98 File Offset: 0x00047098
		public static long ToUnixTimeSeconds(DateTime date)
		{
			return Convert.ToInt64((date.ToUniversalTime() - SystemClock.s_Epoch).TotalSeconds);
		}

		// Token: 0x04000DCA RID: 3530
		private static readonly IntPtr NativeFieldInfoPtr_s_Epoch;

		// Token: 0x04000DCB RID: 3531
		private static readonly IntPtr NativeMethodInfoPtr_get_now_Public_Static_get_DateTime_0;
	}
}
