using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Reflection
{
	// Token: 0x020001CE RID: 462
	public sealed class MonoEventInfo : ValueType
	{
		// Token: 0x06001DB6 RID: 7606 RVA: 0x000A70C8 File Offset: 0x000A52C8
		// Note: this type is marked as 'beforefieldinit'.
		static MonoEventInfo()
		{
			Il2CppClassPointerStore<MonoEventInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Reflection", "MonoEventInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MonoEventInfo>.NativeClassPtr);
			MonoEventInfo.NativeFieldInfoPtr_declaring_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoEventInfo>.NativeClassPtr, "declaring_type");
			MonoEventInfo.NativeFieldInfoPtr_reflected_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoEventInfo>.NativeClassPtr, "reflected_type");
			MonoEventInfo.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoEventInfo>.NativeClassPtr, "name");
			MonoEventInfo.NativeFieldInfoPtr_add_method = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoEventInfo>.NativeClassPtr, "add_method");
			MonoEventInfo.NativeFieldInfoPtr_remove_method = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoEventInfo>.NativeClassPtr, "remove_method");
			MonoEventInfo.NativeFieldInfoPtr_raise_method = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoEventInfo>.NativeClassPtr, "raise_method");
			MonoEventInfo.NativeFieldInfoPtr_attrs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoEventInfo>.NativeClassPtr, "attrs");
			MonoEventInfo.NativeFieldInfoPtr_other_methods = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoEventInfo>.NativeClassPtr, "other_methods");
			MonoEventInfo.NativeMethodInfoPtr_get_event_info_Private_Static_Void_MonoEvent_byref_MonoEventInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoEventInfo>.NativeClassPtr, 100668218);
			MonoEventInfo.NativeMethodInfoPtr_GetEventInfo_Internal_Static_MonoEventInfo_MonoEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoEventInfo>.NativeClassPtr, 100668219);
		}

		// Token: 0x06001DB7 RID: 7607 RVA: 0x000A71C0 File Offset: 0x000A53C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 318430, XrefRangeEnd = 318431, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void get_event_info(MonoEvent ev, out MonoEventInfo info)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ev);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MonoEventInfo.NativeMethodInfoPtr_get_event_info_Private_Static_Void_MonoEvent_byref_MonoEventInfo_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			info = ((intPtr4 == 0) ? null : new MonoEventInfo(intPtr4));
		}

		// Token: 0x06001DB8 RID: 7608 RVA: 0x000A7218 File Offset: 0x000A5418
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 318431, XrefRangeEnd = 318432, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static MonoEventInfo GetEventInfo(MonoEvent ev)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ev);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoEventInfo.NativeMethodInfoPtr_GetEventInfo_Internal_Static_MonoEventInfo_MonoEvent_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new MonoEventInfo(intPtr);
			}
		}

		// Token: 0x06001DB9 RID: 7609 RVA: 0x0000A3F8 File Offset: 0x000085F8
		public MonoEventInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06001DBA RID: 7610 RVA: 0x0000A401 File Offset: 0x00008601
		public MonoEventInfo()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MonoEventInfo>.NativeClassPtr))
		{
		}

		// Token: 0x170005F5 RID: 1525
		// (get) Token: 0x06001DBB RID: 7611 RVA: 0x000A7254 File Offset: 0x000A5454
		// (set) Token: 0x06001DBC RID: 7612 RVA: 0x0000A413 File Offset: 0x00008613
		public unsafe Type declaring_type
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoEventInfo.NativeFieldInfoPtr_declaring_type);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoEventInfo.NativeFieldInfoPtr_declaring_type), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005F6 RID: 1526
		// (get) Token: 0x06001DBD RID: 7613 RVA: 0x000A7284 File Offset: 0x000A5484
		// (set) Token: 0x06001DBE RID: 7614 RVA: 0x0000A432 File Offset: 0x00008632
		public unsafe Type reflected_type
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoEventInfo.NativeFieldInfoPtr_reflected_type);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoEventInfo.NativeFieldInfoPtr_reflected_type), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005F7 RID: 1527
		// (get) Token: 0x06001DBF RID: 7615 RVA: 0x000A72B4 File Offset: 0x000A54B4
		// (set) Token: 0x06001DC0 RID: 7616 RVA: 0x0000A451 File Offset: 0x00008651
		public unsafe string name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoEventInfo.NativeFieldInfoPtr_name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoEventInfo.NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170005F8 RID: 1528
		// (get) Token: 0x06001DC1 RID: 7617 RVA: 0x000A72DC File Offset: 0x000A54DC
		// (set) Token: 0x06001DC2 RID: 7618 RVA: 0x0000A470 File Offset: 0x00008670
		public unsafe MethodInfo add_method
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoEventInfo.NativeFieldInfoPtr_add_method);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MethodInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoEventInfo.NativeFieldInfoPtr_add_method), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005F9 RID: 1529
		// (get) Token: 0x06001DC3 RID: 7619 RVA: 0x000A730C File Offset: 0x000A550C
		// (set) Token: 0x06001DC4 RID: 7620 RVA: 0x0000A48F File Offset: 0x0000868F
		public unsafe MethodInfo remove_method
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoEventInfo.NativeFieldInfoPtr_remove_method);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MethodInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoEventInfo.NativeFieldInfoPtr_remove_method), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005FA RID: 1530
		// (get) Token: 0x06001DC5 RID: 7621 RVA: 0x000A733C File Offset: 0x000A553C
		// (set) Token: 0x06001DC6 RID: 7622 RVA: 0x0000A4AE File Offset: 0x000086AE
		public unsafe MethodInfo raise_method
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoEventInfo.NativeFieldInfoPtr_raise_method);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MethodInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoEventInfo.NativeFieldInfoPtr_raise_method), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005FB RID: 1531
		// (get) Token: 0x06001DC7 RID: 7623 RVA: 0x000A736C File Offset: 0x000A556C
		// (set) Token: 0x06001DC8 RID: 7624 RVA: 0x0000A4CD File Offset: 0x000086CD
		public unsafe EventAttributes attrs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoEventInfo.NativeFieldInfoPtr_attrs);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoEventInfo.NativeFieldInfoPtr_attrs)) = value;
			}
		}

		// Token: 0x170005FC RID: 1532
		// (get) Token: 0x06001DC9 RID: 7625 RVA: 0x000A7394 File Offset: 0x000A5594
		// (set) Token: 0x06001DCA RID: 7626 RVA: 0x0000A4E8 File Offset: 0x000086E8
		public unsafe Il2CppReferenceArray<MethodInfo> other_methods
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoEventInfo.NativeFieldInfoPtr_other_methods);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<MethodInfo>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoEventInfo.NativeFieldInfoPtr_other_methods), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001B29 RID: 6953
		private static readonly IntPtr NativeFieldInfoPtr_declaring_type;

		// Token: 0x04001B2A RID: 6954
		private static readonly IntPtr NativeFieldInfoPtr_reflected_type;

		// Token: 0x04001B2B RID: 6955
		private static readonly IntPtr NativeFieldInfoPtr_name;

		// Token: 0x04001B2C RID: 6956
		private static readonly IntPtr NativeFieldInfoPtr_add_method;

		// Token: 0x04001B2D RID: 6957
		private static readonly IntPtr NativeFieldInfoPtr_remove_method;

		// Token: 0x04001B2E RID: 6958
		private static readonly IntPtr NativeFieldInfoPtr_raise_method;

		// Token: 0x04001B2F RID: 6959
		private static readonly IntPtr NativeFieldInfoPtr_attrs;

		// Token: 0x04001B30 RID: 6960
		private static readonly IntPtr NativeFieldInfoPtr_other_methods;

		// Token: 0x04001B31 RID: 6961
		private static readonly IntPtr NativeMethodInfoPtr_get_event_info_Private_Static_Void_MonoEvent_byref_MonoEventInfo_0;

		// Token: 0x04001B32 RID: 6962
		private static readonly IntPtr NativeMethodInfoPtr_GetEventInfo_Internal_Static_MonoEventInfo_MonoEvent_0;
	}
}
