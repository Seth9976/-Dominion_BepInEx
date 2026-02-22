using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Reflection
{
	// Token: 0x020001B2 RID: 434
	[Serializable]
	public class MethodInfo : MethodBase
	{
		// Token: 0x06001C17 RID: 7191 RVA: 0x000A0684 File Offset: 0x0009E884
		// Note: this type is marked as 'beforefieldinit'.
		static MethodInfo()
		{
			Il2CppClassPointerStore<MethodInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Reflection", "MethodInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MethodInfo>.NativeClassPtr);
			MethodInfo.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethodInfo>.NativeClassPtr, 100667989);
			MethodInfo.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_MethodInfo_MethodInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethodInfo>.NativeClassPtr, 100667990);
			MethodInfo.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_MethodInfo_MethodInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethodInfo>.NativeClassPtr, 100667991);
			MethodInfo.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethodInfo>.NativeClassPtr, 100667992);
			MethodInfo.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethodInfo>.NativeClassPtr, 100667993);
			MethodInfo.NativeMethodInfoPtr_get_MemberType_Public_Virtual_get_MemberTypes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethodInfo>.NativeClassPtr, 100667994);
			MethodInfo.NativeMethodInfoPtr_get_ReturnType_Public_Virtual_New_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethodInfo>.NativeClassPtr, 100667995);
			MethodInfo.NativeMethodInfoPtr_GetGenericArguments_Public_Virtual_Il2CppReferenceArray_1_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethodInfo>.NativeClassPtr, 100667996);
			MethodInfo.NativeMethodInfoPtr_GetGenericMethodDefinition_Public_Virtual_New_MethodInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethodInfo>.NativeClassPtr, 100667997);
			MethodInfo.NativeMethodInfoPtr_MakeGenericMethod_Public_Virtual_New_MethodInfo_Il2CppReferenceArray_1_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethodInfo>.NativeClassPtr, 100667998);
			MethodInfo.NativeMethodInfoPtr_GetBaseMethod_Internal_Virtual_New_MethodInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethodInfo>.NativeClassPtr, 100667999);
		}

		// Token: 0x06001C18 RID: 7192 RVA: 0x000A0790 File Offset: 0x0009E990
		[CallerCount(114)]
		[CachedScanResults(RefRangeStart = 12105, RefRangeEnd = 12219, XrefRangeStart = 12105, XrefRangeEnd = 12219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MethodInfo()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MethodInfo>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodInfo.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C19 RID: 7193 RVA: 0x000A07CC File Offset: 0x0009E9CC
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 317170, RefRangeEnd = 317183, XrefRangeStart = 317168, XrefRangeEnd = 317170, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator ==(MethodInfo left, MethodInfo right)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(left);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(right);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodInfo.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_MethodInfo_MethodInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C1A RID: 7194 RVA: 0x000A0820 File Offset: 0x0009EA20
		[CallerCount(18)]
		[CachedScanResults(RefRangeStart = 317185, RefRangeEnd = 317203, XrefRangeStart = 317183, XrefRangeEnd = 317185, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator !=(MethodInfo left, MethodInfo right)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(left);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(right);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodInfo.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_MethodInfo_MethodInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C1B RID: 7195 RVA: 0x000A0874 File Offset: 0x0009EA74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MethodInfo.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001C1C RID: 7196 RVA: 0x000A08CC File Offset: 0x0009EACC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 317065, RefRangeEnd = 317066, XrefRangeStart = 317065, XrefRangeEnd = 317066, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MethodInfo.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x1700058F RID: 1423
		// (get) Token: 0x06001C1D RID: 7197 RVA: 0x000A0914 File Offset: 0x0009EB14
		public unsafe override MemberTypes MemberType
		{
			[CallerCount(13)]
			[CachedScanResults(RefRangeStart = 14937, RefRangeEnd = 14950, XrefRangeStart = 14937, XrefRangeEnd = 14950, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MethodInfo.NativeMethodInfoPtr_get_MemberType_Public_Virtual_get_MemberTypes_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000590 RID: 1424
		// (get) Token: 0x06001C1E RID: 7198 RVA: 0x000A095C File Offset: 0x0009EB5C
		public unsafe virtual Type ReturnType
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 317203, XrefRangeEnd = 317208, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MethodInfo.NativeMethodInfoPtr_get_ReturnType_Public_Virtual_New_get_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x06001C1F RID: 7199 RVA: 0x000A09A8 File Offset: 0x0009EBA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 317208, XrefRangeEnd = 317215, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Il2CppReferenceArray<Type> GetGenericArguments()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MethodInfo.NativeMethodInfoPtr_GetGenericArguments_Public_Virtual_Il2CppReferenceArray_1_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Type>>(intPtr3) : null;
		}

		// Token: 0x06001C20 RID: 7200 RVA: 0x000A09F4 File Offset: 0x0009EBF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 317215, XrefRangeEnd = 317222, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual MethodInfo GetGenericMethodDefinition()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MethodInfo.NativeMethodInfoPtr_GetGenericMethodDefinition_Public_Virtual_New_MethodInfo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MethodInfo>(intPtr3) : null;
		}

		// Token: 0x06001C21 RID: 7201 RVA: 0x000A0A40 File Offset: 0x0009EC40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 317222, XrefRangeEnd = 317229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual MethodInfo MakeGenericMethod([Optional] Il2CppReferenceArray<Type> typeArguments)
		{
			if (typeArguments == null)
			{
				typeArguments = new Il2CppReferenceArray<Type>(0L);
			}
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(typeArguments);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MethodInfo.NativeMethodInfoPtr_MakeGenericMethod_Public_Virtual_New_MethodInfo_Il2CppReferenceArray_1_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MethodInfo>(intPtr3) : null;
			}
		}

		// Token: 0x06001C22 RID: 7202 RVA: 0x000A0AA8 File Offset: 0x0009ECA8
		[CallerCount(734)]
		[CachedScanResults(RefRangeStart = 3778, RefRangeEnd = 4512, XrefRangeStart = 3778, XrefRangeEnd = 4512, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual MethodInfo GetBaseMethod()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MethodInfo.NativeMethodInfoPtr_GetBaseMethod_Internal_Virtual_New_MethodInfo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MethodInfo>(intPtr3) : null;
		}

		// Token: 0x06001C23 RID: 7203 RVA: 0x00009AC3 File Offset: 0x00007CC3
		public virtual MethodInfo MakeGenericMethod(params Type[] typeArguments)
		{
			return this.MakeGenericMethod(new Il2CppReferenceArray<Type>(typeArguments));
		}

		// Token: 0x06001C24 RID: 7204 RVA: 0x00009AD1 File Offset: 0x00007CD1
		public MethodInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040019D2 RID: 6610
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x040019D3 RID: 6611
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_MethodInfo_MethodInfo_0;

		// Token: 0x040019D4 RID: 6612
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_MethodInfo_MethodInfo_0;

		// Token: 0x040019D5 RID: 6613
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x040019D6 RID: 6614
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x040019D7 RID: 6615
		private static readonly IntPtr NativeMethodInfoPtr_get_MemberType_Public_Virtual_get_MemberTypes_0;

		// Token: 0x040019D8 RID: 6616
		private static readonly IntPtr NativeMethodInfoPtr_get_ReturnType_Public_Virtual_New_get_Type_0;

		// Token: 0x040019D9 RID: 6617
		private static readonly IntPtr NativeMethodInfoPtr_GetGenericArguments_Public_Virtual_Il2CppReferenceArray_1_Type_0;

		// Token: 0x040019DA RID: 6618
		private static readonly IntPtr NativeMethodInfoPtr_GetGenericMethodDefinition_Public_Virtual_New_MethodInfo_0;

		// Token: 0x040019DB RID: 6619
		private static readonly IntPtr NativeMethodInfoPtr_MakeGenericMethod_Public_Virtual_New_MethodInfo_Il2CppReferenceArray_1_Type_0;

		// Token: 0x040019DC RID: 6620
		private static readonly IntPtr NativeMethodInfoPtr_GetBaseMethod_Internal_Virtual_New_MethodInfo_0;
	}
}
