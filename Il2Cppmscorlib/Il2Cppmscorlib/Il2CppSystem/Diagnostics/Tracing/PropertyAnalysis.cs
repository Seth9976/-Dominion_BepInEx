using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Reflection;

namespace Il2CppSystem.Diagnostics.Tracing
{
	// Token: 0x020004D4 RID: 1236
	public sealed class PropertyAnalysis : Object
	{
		// Token: 0x06004862 RID: 18530 RVA: 0x0014BC78 File Offset: 0x00149E78
		// Note: this type is marked as 'beforefieldinit'.
		static PropertyAnalysis()
		{
			Il2CppClassPointerStore<PropertyAnalysis>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Diagnostics.Tracing", "PropertyAnalysis");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PropertyAnalysis>.NativeClassPtr);
			PropertyAnalysis.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyAnalysis>.NativeClassPtr, "name");
			PropertyAnalysis.NativeFieldInfoPtr_getterInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyAnalysis>.NativeClassPtr, "getterInfo");
			PropertyAnalysis.NativeFieldInfoPtr_typeInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyAnalysis>.NativeClassPtr, "typeInfo");
			PropertyAnalysis.NativeFieldInfoPtr_fieldAttribute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyAnalysis>.NativeClassPtr, "fieldAttribute");
			PropertyAnalysis.NativeMethodInfoPtr__ctor_Public_Void_String_MethodInfo_TraceLoggingTypeInfo_EventFieldAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyAnalysis>.NativeClassPtr, 100673997);
		}

		// Token: 0x06004863 RID: 18531 RVA: 0x0014BD0C File Offset: 0x00149F0C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 366369, RefRangeEnd = 366370, XrefRangeStart = 366368, XrefRangeEnd = 366369, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PropertyAnalysis(string name, MethodInfo getterInfo, TraceLoggingTypeInfo typeInfo, EventFieldAttribute fieldAttribute)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PropertyAnalysis>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(getterInfo);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(typeInfo);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(fieldAttribute);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyAnalysis.NativeMethodInfoPtr__ctor_Public_Void_String_MethodInfo_TraceLoggingTypeInfo_EventFieldAttribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004864 RID: 18532 RVA: 0x0001B6D2 File Offset: 0x000198D2
		public PropertyAnalysis(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17001247 RID: 4679
		// (get) Token: 0x06004865 RID: 18533 RVA: 0x0014BD90 File Offset: 0x00149F90
		// (set) Token: 0x06004866 RID: 18534 RVA: 0x0001B6DB File Offset: 0x000198DB
		public unsafe string name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyAnalysis.NativeFieldInfoPtr_name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyAnalysis.NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001248 RID: 4680
		// (get) Token: 0x06004867 RID: 18535 RVA: 0x0014BDB8 File Offset: 0x00149FB8
		// (set) Token: 0x06004868 RID: 18536 RVA: 0x0001B6FA File Offset: 0x000198FA
		public unsafe MethodInfo getterInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyAnalysis.NativeFieldInfoPtr_getterInfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MethodInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyAnalysis.NativeFieldInfoPtr_getterInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001249 RID: 4681
		// (get) Token: 0x06004869 RID: 18537 RVA: 0x0014BDE8 File Offset: 0x00149FE8
		// (set) Token: 0x0600486A RID: 18538 RVA: 0x0001B719 File Offset: 0x00019919
		public unsafe TraceLoggingTypeInfo typeInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyAnalysis.NativeFieldInfoPtr_typeInfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TraceLoggingTypeInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyAnalysis.NativeFieldInfoPtr_typeInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700124A RID: 4682
		// (get) Token: 0x0600486B RID: 18539 RVA: 0x0014BE18 File Offset: 0x0014A018
		// (set) Token: 0x0600486C RID: 18540 RVA: 0x0001B738 File Offset: 0x00019938
		public unsafe EventFieldAttribute fieldAttribute
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyAnalysis.NativeFieldInfoPtr_fieldAttribute);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventFieldAttribute>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyAnalysis.NativeFieldInfoPtr_fieldAttribute), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003A8D RID: 14989
		private static readonly IntPtr NativeFieldInfoPtr_name;

		// Token: 0x04003A8E RID: 14990
		private static readonly IntPtr NativeFieldInfoPtr_getterInfo;

		// Token: 0x04003A8F RID: 14991
		private static readonly IntPtr NativeFieldInfoPtr_typeInfo;

		// Token: 0x04003A90 RID: 14992
		private static readonly IntPtr NativeFieldInfoPtr_fieldAttribute;

		// Token: 0x04003A91 RID: 14993
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_MethodInfo_TraceLoggingTypeInfo_EventFieldAttribute_0;
	}
}
