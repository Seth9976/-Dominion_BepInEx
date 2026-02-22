using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Reflection;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem
{
	// Token: 0x02000130 RID: 304
	[Serializable]
	[StructLayout(2)]
	public struct RuntimeMethodHandle
	{
		// Token: 0x060015AF RID: 5551 RVA: 0x0008479C File Offset: 0x0008299C
		// Note: this type is marked as 'beforefieldinit'.
		static RuntimeMethodHandle()
		{
			Il2CppClassPointerStore<RuntimeMethodHandle>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "RuntimeMethodHandle");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RuntimeMethodHandle>.NativeClassPtr);
			RuntimeMethodHandle.NativeFieldInfoPtr_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeMethodHandle>.NativeClassPtr, "value");
			RuntimeMethodHandle.NativeMethodInfoPtr__ctor_Private_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeMethodHandle>.NativeClassPtr, 100666974);
			RuntimeMethodHandle.NativeMethodInfoPtr_get_Value_Public_get_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeMethodHandle>.NativeClassPtr, 100666975);
			RuntimeMethodHandle.NativeMethodInfoPtr_GetObjectData_Public_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeMethodHandle>.NativeClassPtr, 100666976);
			RuntimeMethodHandle.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeMethodHandle>.NativeClassPtr, 100666977);
			RuntimeMethodHandle.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeMethodHandle>.NativeClassPtr, 100666978);
			RuntimeMethodHandle.NativeMethodInfoPtr_ConstructInstantiation_Internal_Static_String_RuntimeMethodInfo_TypeNameFormatFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeMethodHandle>.NativeClassPtr, 100666979);
			RuntimeMethodHandle.NativeMethodInfoPtr_IsNullHandle_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeMethodHandle>.NativeClassPtr, 100666980);
		}

		// Token: 0x060015B0 RID: 5552 RVA: 0x0008486C File Offset: 0x00082A6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 307951, XrefRangeEnd = 307964, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RuntimeMethodHandle(SerializationInfo info, StreamingContext context)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeMethodHandle.NativeMethodInfoPtr__ctor_Private_Void_SerializationInfo_StreamingContext_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700041C RID: 1052
		// (get) Token: 0x060015B1 RID: 5553 RVA: 0x000848BC File Offset: 0x00082ABC
		public unsafe IntPtr Value
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeMethodHandle.NativeMethodInfoPtr_get_Value_Public_get_IntPtr_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060015B2 RID: 5554 RVA: 0x000848EC File Offset: 0x00082AEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 307964, XrefRangeEnd = 307979, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeMethodHandle.NativeMethodInfoPtr_GetObjectData_Public_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060015B3 RID: 5555 RVA: 0x0008493C File Offset: 0x00082B3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 307979, XrefRangeEnd = 307991, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeMethodHandle.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060015B4 RID: 5556 RVA: 0x00084980 File Offset: 0x00082B80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeMethodHandle.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060015B5 RID: 5557 RVA: 0x000849B0 File Offset: 0x00082BB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 307991, XrefRangeEnd = 308009, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ConstructInstantiation(RuntimeMethodInfo method, TypeNameFormatFlags format)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(method);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref format;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeMethodHandle.NativeMethodInfoPtr_ConstructInstantiation_Internal_Static_String_RuntimeMethodInfo_TypeNameFormatFlags_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060015B6 RID: 5558 RVA: 0x000849FC File Offset: 0x00082BFC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 308011, RefRangeEnd = 308012, XrefRangeStart = 308009, XrefRangeEnd = 308011, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsNullHandle()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeMethodHandle.NativeMethodInfoPtr_IsNullHandle_Internal_Boolean_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060015B7 RID: 5559 RVA: 0x0000787B File Offset: 0x00005A7B
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RuntimeMethodHandle>.NativeClassPtr, ref this));
		}

		// Token: 0x0400125E RID: 4702
		private static readonly IntPtr NativeFieldInfoPtr_value;

		// Token: 0x0400125F RID: 4703
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x04001260 RID: 4704
		private static readonly IntPtr NativeMethodInfoPtr_get_Value_Public_get_IntPtr_0;

		// Token: 0x04001261 RID: 4705
		private static readonly IntPtr NativeMethodInfoPtr_GetObjectData_Public_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x04001262 RID: 4706
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04001263 RID: 4707
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04001264 RID: 4708
		private static readonly IntPtr NativeMethodInfoPtr_ConstructInstantiation_Internal_Static_String_RuntimeMethodInfo_TypeNameFormatFlags_0;

		// Token: 0x04001265 RID: 4709
		private static readonly IntPtr NativeMethodInfoPtr_IsNullHandle_Internal_Boolean_0;

		// Token: 0x04001266 RID: 4710
		[FieldOffset(0)]
		public IntPtr value;
	}
}
