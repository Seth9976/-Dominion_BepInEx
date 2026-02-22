using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem
{
	// Token: 0x02000139 RID: 313
	[Serializable]
	public class TimeZone : Object
	{
		// Token: 0x0600168C RID: 5772 RVA: 0x00087AD8 File Offset: 0x00085CD8
		// Note: this type is marked as 'beforefieldinit'.
		static TimeZone()
		{
			Il2CppClassPointerStore<TimeZone>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "TimeZone");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TimeZone>.NativeClassPtr);
			TimeZone.NativeFieldInfoPtr_tz_lock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeZone>.NativeClassPtr, "tz_lock");
			TimeZone.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZone>.NativeClassPtr, 100667088);
		}

		// Token: 0x0600168D RID: 5773 RVA: 0x00087B30 File Offset: 0x00085D30
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TimeZone()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TimeZone>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZone.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600168E RID: 5774 RVA: 0x00007E9A File Offset: 0x0000609A
		public TimeZone(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000456 RID: 1110
		// (get) Token: 0x0600168F RID: 5775 RVA: 0x00087B6C File Offset: 0x00085D6C
		// (set) Token: 0x06001690 RID: 5776 RVA: 0x00007EA3 File Offset: 0x000060A3
		public unsafe static Object tz_lock
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TimeZone.NativeFieldInfoPtr_tz_lock, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TimeZone.NativeFieldInfoPtr_tz_lock, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040014B3 RID: 5299
		private static readonly IntPtr NativeFieldInfoPtr_tz_lock;

		// Token: 0x040014B4 RID: 5300
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
