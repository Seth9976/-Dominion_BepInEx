using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Reflection;

namespace Il2CppSystem.Runtime.Remoting.Messaging
{
	// Token: 0x020003E4 RID: 996
	public class ArgInfo : Object
	{
		// Token: 0x06003F17 RID: 16151 RVA: 0x00125D28 File Offset: 0x00123F28
		// Note: this type is marked as 'beforefieldinit'.
		static ArgInfo()
		{
			Il2CppClassPointerStore<ArgInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting.Messaging", "ArgInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ArgInfo>.NativeClassPtr);
			ArgInfo.NativeFieldInfoPtr__paramMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArgInfo>.NativeClassPtr, "_paramMap");
			ArgInfo.NativeFieldInfoPtr__inoutArgCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArgInfo>.NativeClassPtr, "_inoutArgCount");
			ArgInfo.NativeFieldInfoPtr__method = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArgInfo>.NativeClassPtr, "_method");
			ArgInfo.NativeMethodInfoPtr__ctor_Public_Void_MethodBase_ArgInfoType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArgInfo>.NativeClassPtr, 100672541);
			ArgInfo.NativeMethodInfoPtr_GetInOutArgs_Public_Il2CppReferenceArray_1_Object_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArgInfo>.NativeClassPtr, 100672542);
		}

		// Token: 0x06003F18 RID: 16152 RVA: 0x00125DBC File Offset: 0x00123FBC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 354246, RefRangeEnd = 354248, XrefRangeStart = 354237, XrefRangeEnd = 354246, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ArgInfo(MethodBase method, ArgInfoType type)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ArgInfo>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(method);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref type;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArgInfo.NativeMethodInfoPtr__ctor_Public_Void_MethodBase_ArgInfoType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003F19 RID: 16153 RVA: 0x00125E18 File Offset: 0x00124018
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 354252, RefRangeEnd = 354254, XrefRangeStart = 354248, XrefRangeEnd = 354252, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppReferenceArray<Object> GetInOutArgs(Il2CppReferenceArray<Object> args)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArgInfo.NativeMethodInfoPtr_GetInOutArgs_Public_Il2CppReferenceArray_1_Object_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr3) : null;
			}
		}

		// Token: 0x06003F1A RID: 16154 RVA: 0x00017D6B File Offset: 0x00015F6B
		public ArgInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000FE8 RID: 4072
		// (get) Token: 0x06003F1B RID: 16155 RVA: 0x00125E68 File Offset: 0x00124068
		// (set) Token: 0x06003F1C RID: 16156 RVA: 0x00017D74 File Offset: 0x00015F74
		public unsafe Il2CppStructArray<int> _paramMap
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArgInfo.NativeFieldInfoPtr__paramMap);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArgInfo.NativeFieldInfoPtr__paramMap), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000FE9 RID: 4073
		// (get) Token: 0x06003F1D RID: 16157 RVA: 0x00125E98 File Offset: 0x00124098
		// (set) Token: 0x06003F1E RID: 16158 RVA: 0x00017D93 File Offset: 0x00015F93
		public unsafe int _inoutArgCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArgInfo.NativeFieldInfoPtr__inoutArgCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArgInfo.NativeFieldInfoPtr__inoutArgCount)) = value;
			}
		}

		// Token: 0x17000FEA RID: 4074
		// (get) Token: 0x06003F1F RID: 16159 RVA: 0x00125EC0 File Offset: 0x001240C0
		// (set) Token: 0x06003F20 RID: 16160 RVA: 0x00017DAE File Offset: 0x00015FAE
		public unsafe MethodBase _method
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArgInfo.NativeFieldInfoPtr__method);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MethodBase>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArgInfo.NativeFieldInfoPtr__method), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040033DD RID: 13277
		private static readonly IntPtr NativeFieldInfoPtr__paramMap;

		// Token: 0x040033DE RID: 13278
		private static readonly IntPtr NativeFieldInfoPtr__inoutArgCount;

		// Token: 0x040033DF RID: 13279
		private static readonly IntPtr NativeFieldInfoPtr__method;

		// Token: 0x040033E0 RID: 13280
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_MethodBase_ArgInfoType_0;

		// Token: 0x040033E1 RID: 13281
		private static readonly IntPtr NativeMethodInfoPtr_GetInOutArgs_Public_Il2CppReferenceArray_1_Object_Il2CppReferenceArray_1_Object_0;
	}
}
