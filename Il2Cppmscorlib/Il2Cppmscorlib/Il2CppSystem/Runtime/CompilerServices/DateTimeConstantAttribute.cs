using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Runtime.CompilerServices
{
	// Token: 0x0200042C RID: 1068
	[Serializable]
	public sealed class DateTimeConstantAttribute : CustomConstantAttribute
	{
		// Token: 0x0600422F RID: 16943 RVA: 0x00130FE0 File Offset: 0x0012F1E0
		// Note: this type is marked as 'beforefieldinit'.
		static DateTimeConstantAttribute()
		{
			Il2CppClassPointerStore<DateTimeConstantAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.CompilerServices", "DateTimeConstantAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DateTimeConstantAttribute>.NativeClassPtr);
			DateTimeConstantAttribute.NativeFieldInfoPtr_date = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeConstantAttribute>.NativeClassPtr, "date");
			DateTimeConstantAttribute.NativeMethodInfoPtr_get_Value_Public_Virtual_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeConstantAttribute>.NativeClassPtr, 100672926);
		}

		// Token: 0x170010F3 RID: 4339
		// (get) Token: 0x06004230 RID: 16944 RVA: 0x00131038 File Offset: 0x0012F238
		public unsafe override Object Value
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 357105, XrefRangeEnd = 357108, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeConstantAttribute.NativeMethodInfoPtr_get_Value_Public_Virtual_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06004231 RID: 16945 RVA: 0x000193ED File Offset: 0x000175ED
		public DateTimeConstantAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170010F2 RID: 4338
		// (get) Token: 0x06004232 RID: 16946 RVA: 0x00131078 File Offset: 0x0012F278
		// (set) Token: 0x06004233 RID: 16947 RVA: 0x000193F6 File Offset: 0x000175F6
		public unsafe DateTime date
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeConstantAttribute.NativeFieldInfoPtr_date);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeConstantAttribute.NativeFieldInfoPtr_date)) = value;
			}
		}

		// Token: 0x040035E1 RID: 13793
		private static readonly IntPtr NativeFieldInfoPtr_date;

		// Token: 0x040035E2 RID: 13794
		private static readonly IntPtr NativeMethodInfoPtr_get_Value_Public_Virtual_get_Object_0;
	}
}
