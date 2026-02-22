using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000097 RID: 151
	[StructLayout(2)]
	public struct PropertyName
	{
		// Token: 0x06000F4C RID: 3916 RVA: 0x0003FC14 File Offset: 0x0003DE14
		// Note: this type is marked as 'beforefieldinit'.
		static PropertyName()
		{
			Il2CppClassPointerStore<PropertyName>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "PropertyName");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PropertyName>.NativeClassPtr);
			PropertyName.NativeFieldInfoPtr_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyName>.NativeClassPtr, "id");
			PropertyName.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyName>.NativeClassPtr, 100664267);
			PropertyName.NativeMethodInfoPtr__ctor_Public_Void_PropertyName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyName>.NativeClassPtr, 100664268);
			PropertyName.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_PropertyName_PropertyName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyName>.NativeClassPtr, 100664269);
			PropertyName.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyName>.NativeClassPtr, 100664270);
			PropertyName.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyName>.NativeClassPtr, 100664271);
			PropertyName.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_PropertyName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyName>.NativeClassPtr, 100664272);
			PropertyName.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyName>.NativeClassPtr, 100664273);
		}

		// Token: 0x06000F4D RID: 3917 RVA: 0x0003FCE4 File Offset: 0x0003DEE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67905, XrefRangeEnd = 67907, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PropertyName(string name)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyName.NativeMethodInfoPtr__ctor_Public_Void_String_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000F4E RID: 3918 RVA: 0x0003FD1C File Offset: 0x0003DF1C
		[CallerCount(0)]
		public unsafe PropertyName(PropertyName other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyName.NativeMethodInfoPtr__ctor_Public_Void_PropertyName_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000F4F RID: 3919 RVA: 0x0003FD50 File Offset: 0x0003DF50
		[CallerCount(0)]
		public unsafe static bool operator ==(PropertyName lhs, PropertyName rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyName.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_PropertyName_PropertyName_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000F50 RID: 3920 RVA: 0x0003FD9C File Offset: 0x0003DF9C
		[CallerCount(26)]
		[CachedScanResults(RefRangeStart = 62259, RefRangeEnd = 62285, XrefRangeStart = 62259, XrefRangeEnd = 62285, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyName.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000F51 RID: 3921 RVA: 0x0003FDCC File Offset: 0x0003DFCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67907, XrefRangeEnd = 67910, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyName.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F52 RID: 3922 RVA: 0x0003FE10 File Offset: 0x0003E010
		[CallerCount(0)]
		public unsafe bool Equals(PropertyName other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyName.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_PropertyName_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F53 RID: 3923 RVA: 0x0003FE50 File Offset: 0x0003E050
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67910, XrefRangeEnd = 67916, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyName.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000F54 RID: 3924 RVA: 0x00009B34 File Offset: 0x00007D34
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PropertyName>.NativeClassPtr, ref this));
		}

		// Token: 0x06000F55 RID: 3925 RVA: 0x0003FE7C File Offset: 0x0003E07C
		public static bool IsNullOrEmpty(PropertyName prop)
		{
			return prop.id == 0;
		}

		// Token: 0x06000F56 RID: 3926 RVA: 0x0003FE98 File Offset: 0x0003E098
		public static bool operator !=(PropertyName lhs, PropertyName rhs)
		{
			return lhs.id != rhs.id;
		}

		// Token: 0x06000F57 RID: 3927 RVA: 0x0003FEBC File Offset: 0x0003E0BC
		public static implicit operator PropertyName(string name)
		{
			return new PropertyName(name);
		}

		// Token: 0x06000F58 RID: 3928 RVA: 0x0003FED4 File Offset: 0x0003E0D4
		public static implicit operator PropertyName(int id)
		{
			return new PropertyName(id);
		}

		// Token: 0x04000BC4 RID: 3012
		private static readonly IntPtr NativeFieldInfoPtr_id;

		// Token: 0x04000BC5 RID: 3013
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x04000BC6 RID: 3014
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_PropertyName_0;

		// Token: 0x04000BC7 RID: 3015
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_PropertyName_PropertyName_0;

		// Token: 0x04000BC8 RID: 3016
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04000BC9 RID: 3017
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04000BCA RID: 3018
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_PropertyName_0;

		// Token: 0x04000BCB RID: 3019
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04000BCC RID: 3020
		[FieldOffset(0)]
		public int id;
	}
}
