using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Reflection;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem
{
	// Token: 0x02000111 RID: 273
	[Serializable]
	public class Delegate : Object
	{
		// Token: 0x0600141E RID: 5150 RVA: 0x0007DFD0 File Offset: 0x0007C1D0
		// Note: this type is marked as 'beforefieldinit'.
		static Delegate()
		{
			Il2CppClassPointerStore<Delegate>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "Delegate");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Delegate>.NativeClassPtr);
			Delegate.NativeFieldInfoPtr_method_ptr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Delegate>.NativeClassPtr, "method_ptr");
			Delegate.NativeFieldInfoPtr_invoke_impl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Delegate>.NativeClassPtr, "invoke_impl");
			Delegate.NativeFieldInfoPtr_m_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Delegate>.NativeClassPtr, "m_target");
			Delegate.NativeFieldInfoPtr_method = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Delegate>.NativeClassPtr, "method");
			Delegate.NativeFieldInfoPtr_delegate_trampoline = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Delegate>.NativeClassPtr, "delegate_trampoline");
			Delegate.NativeFieldInfoPtr_extra_arg = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Delegate>.NativeClassPtr, "extra_arg");
			Delegate.NativeFieldInfoPtr_method_code = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Delegate>.NativeClassPtr, "method_code");
			Delegate.NativeFieldInfoPtr_method_info = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Delegate>.NativeClassPtr, "method_info");
			Delegate.NativeFieldInfoPtr_original_method_info = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Delegate>.NativeClassPtr, "original_method_info");
			Delegate.NativeFieldInfoPtr_data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Delegate>.NativeClassPtr, "data");
			Delegate.NativeFieldInfoPtr_method_is_virtual = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Delegate>.NativeClassPtr, "method_is_virtual");
			Delegate.NativeMethodInfoPtr_get_Method_Public_get_MethodInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Delegate>.NativeClassPtr, 100666742);
			Delegate.NativeMethodInfoPtr_GetVirtualMethod_internal_Private_MethodInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Delegate>.NativeClassPtr, 100666743);
			Delegate.NativeMethodInfoPtr_get_Target_Public_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Delegate>.NativeClassPtr, 100666744);
			Delegate.NativeMethodInfoPtr_CreateDelegate_internal_Internal_Static_Delegate_Type_Object_MethodInfo_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Delegate>.NativeClassPtr, 100666745);
			Delegate.NativeMethodInfoPtr_arg_type_match_Private_Static_Boolean_Type_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Delegate>.NativeClassPtr, 100666746);
			Delegate.NativeMethodInfoPtr_arg_type_match_this_Private_Static_Boolean_Type_Type_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Delegate>.NativeClassPtr, 100666747);
			Delegate.NativeMethodInfoPtr_return_type_match_Private_Static_Boolean_Type_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Delegate>.NativeClassPtr, 100666748);
			Delegate.NativeMethodInfoPtr_CreateDelegate_Public_Static_Delegate_Type_Object_MethodInfo_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Delegate>.NativeClassPtr, 100666749);
			Delegate.NativeMethodInfoPtr_CreateDelegate_Private_Static_Delegate_Type_Object_MethodInfo_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Delegate>.NativeClassPtr, 100666750);
			Delegate.NativeMethodInfoPtr_CreateDelegate_Public_Static_Delegate_Type_Object_MethodInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Delegate>.NativeClassPtr, 100666751);
			Delegate.NativeMethodInfoPtr_CreateDelegate_Public_Static_Delegate_Type_MethodInfo_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Delegate>.NativeClassPtr, 100666752);
			Delegate.NativeMethodInfoPtr_CreateDelegate_Public_Static_Delegate_Type_MethodInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Delegate>.NativeClassPtr, 100666753);
			Delegate.NativeMethodInfoPtr_CreateDelegate_Public_Static_Delegate_Type_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Delegate>.NativeClassPtr, 100666754);
			Delegate.NativeMethodInfoPtr_GetCandidateMethod_Private_Static_MethodInfo_Type_Type_String_BindingFlags_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Delegate>.NativeClassPtr, 100666755);
			Delegate.NativeMethodInfoPtr_CreateDelegate_Public_Static_Delegate_Type_Type_String_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Delegate>.NativeClassPtr, 100666756);
			Delegate.NativeMethodInfoPtr_CreateDelegate_Public_Static_Delegate_Type_Type_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Delegate>.NativeClassPtr, 100666757);
			Delegate.NativeMethodInfoPtr_CreateDelegate_Public_Static_Delegate_Type_Object_String_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Delegate>.NativeClassPtr, 100666758);
			Delegate.NativeMethodInfoPtr_CreateDelegate_Public_Static_Delegate_Type_Object_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Delegate>.NativeClassPtr, 100666759);
			Delegate.NativeMethodInfoPtr_Clone_Public_Virtual_New_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Delegate>.NativeClassPtr, 100666760);
			Delegate.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Delegate>.NativeClassPtr, 100666761);
			Delegate.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Delegate>.NativeClassPtr, 100666762);
			Delegate.NativeMethodInfoPtr_GetMethodImpl_Protected_Virtual_New_MethodInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Delegate>.NativeClassPtr, 100666763);
			Delegate.NativeMethodInfoPtr_GetObjectData_Public_Virtual_New_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Delegate>.NativeClassPtr, 100666764);
			Delegate.NativeMethodInfoPtr_GetInvocationList_Public_Virtual_New_Il2CppReferenceArray_1_Delegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Delegate>.NativeClassPtr, 100666765);
			Delegate.NativeMethodInfoPtr_Combine_Public_Static_Delegate_Delegate_Delegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Delegate>.NativeClassPtr, 100666766);
			Delegate.NativeMethodInfoPtr_Combine_Public_Static_Delegate_Il2CppReferenceArray_1_Delegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Delegate>.NativeClassPtr, 100666767);
			Delegate.NativeMethodInfoPtr_CombineImpl_Protected_Virtual_New_Delegate_Delegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Delegate>.NativeClassPtr, 100666768);
			Delegate.NativeMethodInfoPtr_Remove_Public_Static_Delegate_Delegate_Delegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Delegate>.NativeClassPtr, 100666769);
			Delegate.NativeMethodInfoPtr_RemoveImpl_Protected_Virtual_New_Delegate_Delegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Delegate>.NativeClassPtr, 100666770);
			Delegate.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Delegate_Delegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Delegate>.NativeClassPtr, 100666771);
			Delegate.NativeMethodInfoPtr_CreateDelegateNoSecurityCheck_Internal_Static_Delegate_RuntimeType_Object_MethodInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Delegate>.NativeClassPtr, 100666772);
			Delegate.NativeMethodInfoPtr_AllocDelegateLike_internal_Internal_Static_MulticastDelegate_Delegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Delegate>.NativeClassPtr, 100666773);
		}

		// Token: 0x170003D7 RID: 983
		// (get) Token: 0x0600141F RID: 5151 RVA: 0x0007E35C File Offset: 0x0007C55C
		public unsafe MethodInfo Method
		{
			[CallerCount(16)]
			[CachedScanResults(RefRangeStart = 14894, RefRangeEnd = 14910, XrefRangeStart = 14894, XrefRangeEnd = 14910, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Delegate.NativeMethodInfoPtr_get_Method_Public_get_MethodInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MethodInfo>(intPtr3) : null;
			}
		}

		// Token: 0x06001420 RID: 5152 RVA: 0x0007E39C File Offset: 0x0007C59C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 304885, XrefRangeEnd = 304886, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MethodInfo GetVirtualMethod_internal()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Delegate.NativeMethodInfoPtr_GetVirtualMethod_internal_Private_MethodInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MethodInfo>(intPtr3) : null;
		}

		// Token: 0x170003D8 RID: 984
		// (get) Token: 0x06001421 RID: 5153 RVA: 0x0007E3DC File Offset: 0x0007C5DC
		public unsafe Object Target
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 5350, RefRangeEnd = 5351, XrefRangeStart = 5350, XrefRangeEnd = 5351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Delegate.NativeMethodInfoPtr_get_Target_Public_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06001422 RID: 5154 RVA: 0x0007E41C File Offset: 0x0007C61C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 304886, XrefRangeEnd = 304887, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Delegate CreateDelegate_internal(Type type, Object target, MethodInfo info, bool throwOnBindFailure)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(target);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(info);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref throwOnBindFailure;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Delegate.NativeMethodInfoPtr_CreateDelegate_internal_Internal_Static_Delegate_Type_Object_MethodInfo_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Delegate>(intPtr3) : null;
		}

		// Token: 0x06001423 RID: 5155 RVA: 0x0007E494 File Offset: 0x0007C694
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 304905, RefRangeEnd = 304911, XrefRangeStart = 304887, XrefRangeEnd = 304905, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool arg_type_match(Type delArgType, Type argType)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(delArgType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(argType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Delegate.NativeMethodInfoPtr_arg_type_match_Private_Static_Boolean_Type_Type_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001424 RID: 5156 RVA: 0x0007E4E8 File Offset: 0x0007C6E8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 304917, RefRangeEnd = 304918, XrefRangeStart = 304911, XrefRangeEnd = 304917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool arg_type_match_this(Type delArgType, Type argType, bool boxedThis)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(delArgType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(argType);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref boxedThis;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Delegate.NativeMethodInfoPtr_arg_type_match_this_Private_Static_Boolean_Type_Type_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001425 RID: 5157 RVA: 0x0007E54C File Offset: 0x0007C74C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 304924, RefRangeEnd = 304926, XrefRangeStart = 304918, XrefRangeEnd = 304924, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool return_type_match(Type delReturnType, Type returnType)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(delReturnType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(returnType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Delegate.NativeMethodInfoPtr_return_type_match_Private_Static_Boolean_Type_Type_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001426 RID: 5158 RVA: 0x0007E5A0 File Offset: 0x0007C7A0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 304927, RefRangeEnd = 304928, XrefRangeStart = 304926, XrefRangeEnd = 304927, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Delegate CreateDelegate(Type type, Object firstArgument, MethodInfo method, bool throwOnBindFailure)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(firstArgument);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(method);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref throwOnBindFailure;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Delegate.NativeMethodInfoPtr_CreateDelegate_Public_Static_Delegate_Type_Object_MethodInfo_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Delegate>(intPtr3) : null;
		}

		// Token: 0x06001427 RID: 5159 RVA: 0x0007E618 File Offset: 0x0007C818
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 304968, RefRangeEnd = 304972, XrefRangeStart = 304928, XrefRangeEnd = 304968, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Delegate CreateDelegate(Type type, Object firstArgument, MethodInfo method, bool throwOnBindFailure, bool allowClosed)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(firstArgument);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(method);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref throwOnBindFailure;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref allowClosed;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Delegate.NativeMethodInfoPtr_CreateDelegate_Private_Static_Delegate_Type_Object_MethodInfo_Boolean_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Delegate>(intPtr3) : null;
		}

		// Token: 0x06001428 RID: 5160 RVA: 0x0007E69C File Offset: 0x0007C89C
		[CallerCount(22)]
		[CachedScanResults(RefRangeStart = 304973, RefRangeEnd = 304995, XrefRangeStart = 304972, XrefRangeEnd = 304973, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Delegate CreateDelegate(Type type, Object firstArgument, MethodInfo method)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(firstArgument);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(method);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Delegate.NativeMethodInfoPtr_CreateDelegate_Public_Static_Delegate_Type_Object_MethodInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Delegate>(intPtr3) : null;
		}

		// Token: 0x06001429 RID: 5161 RVA: 0x0007E704 File Offset: 0x0007C904
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 304996, RefRangeEnd = 304997, XrefRangeStart = 304995, XrefRangeEnd = 304996, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Delegate CreateDelegate(Type type, MethodInfo method, bool throwOnBindFailure)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(method);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref throwOnBindFailure;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Delegate.NativeMethodInfoPtr_CreateDelegate_Public_Static_Delegate_Type_MethodInfo_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Delegate>(intPtr3) : null;
		}

		// Token: 0x0600142A RID: 5162 RVA: 0x0007E768 File Offset: 0x0007C968
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 304998, RefRangeEnd = 305006, XrefRangeStart = 304997, XrefRangeEnd = 304998, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Delegate CreateDelegate(Type type, MethodInfo method)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(method);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Delegate.NativeMethodInfoPtr_CreateDelegate_Public_Static_Delegate_Type_MethodInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Delegate>(intPtr3) : null;
		}

		// Token: 0x0600142B RID: 5163 RVA: 0x0007E7C0 File Offset: 0x0007C9C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 305006, XrefRangeEnd = 305010, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Delegate CreateDelegate(Type type, Object target, string method)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(target);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(method);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Delegate.NativeMethodInfoPtr_CreateDelegate_Public_Static_Delegate_Type_Object_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Delegate>(intPtr3) : null;
		}

		// Token: 0x0600142C RID: 5164 RVA: 0x0007E828 File Offset: 0x0007CA28
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 305039, RefRangeEnd = 305044, XrefRangeStart = 305010, XrefRangeEnd = 305039, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static MethodInfo GetCandidateMethod(Type type, Type target, string method, BindingFlags bflags, bool ignoreCase, bool throwOnBindFailure)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(target);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(method);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bflags;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ignoreCase;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref throwOnBindFailure;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Delegate.NativeMethodInfoPtr_GetCandidateMethod_Private_Static_MethodInfo_Type_Type_String_BindingFlags_Boolean_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MethodInfo>(intPtr3) : null;
		}

		// Token: 0x0600142D RID: 5165 RVA: 0x0007E8BC File Offset: 0x0007CABC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 305044, XrefRangeEnd = 305051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Delegate CreateDelegate(Type type, Type target, string method, bool ignoreCase, bool throwOnBindFailure)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(target);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(method);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ignoreCase;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref throwOnBindFailure;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Delegate.NativeMethodInfoPtr_CreateDelegate_Public_Static_Delegate_Type_Type_String_Boolean_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Delegate>(intPtr3) : null;
		}

		// Token: 0x0600142E RID: 5166 RVA: 0x0007E940 File Offset: 0x0007CB40
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 305058, RefRangeEnd = 305059, XrefRangeStart = 305051, XrefRangeEnd = 305058, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Delegate CreateDelegate(Type type, Type target, string method)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(target);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(method);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Delegate.NativeMethodInfoPtr_CreateDelegate_Public_Static_Delegate_Type_Type_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Delegate>(intPtr3) : null;
		}

		// Token: 0x0600142F RID: 5167 RVA: 0x0007E9A8 File Offset: 0x0007CBA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 305059, XrefRangeEnd = 305063, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Delegate CreateDelegate(Type type, Object target, string method, bool ignoreCase, bool throwOnBindFailure)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(target);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(method);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ignoreCase;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref throwOnBindFailure;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Delegate.NativeMethodInfoPtr_CreateDelegate_Public_Static_Delegate_Type_Object_String_Boolean_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Delegate>(intPtr3) : null;
		}

		// Token: 0x06001430 RID: 5168 RVA: 0x0007EA2C File Offset: 0x0007CC2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 305063, XrefRangeEnd = 305067, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Delegate CreateDelegate(Type type, Object target, string method, bool ignoreCase)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(target);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(method);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ignoreCase;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Delegate.NativeMethodInfoPtr_CreateDelegate_Public_Static_Delegate_Type_Object_String_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Delegate>(intPtr3) : null;
		}

		// Token: 0x06001431 RID: 5169 RVA: 0x0007EAA4 File Offset: 0x0007CCA4
		[CallerCount(92)]
		[CachedScanResults(RefRangeStart = 267191, RefRangeEnd = 267283, XrefRangeStart = 267191, XrefRangeEnd = 267283, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Object Clone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Delegate.NativeMethodInfoPtr_Clone_Public_Virtual_New_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06001432 RID: 5170 RVA: 0x0007EAF0 File Offset: 0x0007CCF0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 305071, RefRangeEnd = 305072, XrefRangeStart = 305067, XrefRangeEnd = 305071, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Delegate.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001433 RID: 5171 RVA: 0x0007EB48 File Offset: 0x0007CD48
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 305076, RefRangeEnd = 305077, XrefRangeStart = 305072, XrefRangeEnd = 305076, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Delegate.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001434 RID: 5172 RVA: 0x0007EB90 File Offset: 0x0007CD90
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 305082, RefRangeEnd = 305083, XrefRangeStart = 305077, XrefRangeEnd = 305082, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual MethodInfo GetMethodImpl()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Delegate.NativeMethodInfoPtr_GetMethodImpl_Protected_Virtual_New_MethodInfo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MethodInfo>(intPtr3) : null;
		}

		// Token: 0x06001435 RID: 5173 RVA: 0x0007EBDC File Offset: 0x0007CDDC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 305117, RefRangeEnd = 305118, XrefRangeStart = 305083, XrefRangeEnd = 305117, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Delegate.NativeMethodInfoPtr_GetObjectData_Public_Virtual_New_Void_SerializationInfo_StreamingContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001436 RID: 5174 RVA: 0x0007EC40 File Offset: 0x0007CE40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 305118, XrefRangeEnd = 305122, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Il2CppReferenceArray<Delegate> GetInvocationList()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Delegate.NativeMethodInfoPtr_GetInvocationList_Public_Virtual_New_Il2CppReferenceArray_1_Delegate_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Delegate>>(intPtr3) : null;
		}

		// Token: 0x06001437 RID: 5175 RVA: 0x0007EC8C File Offset: 0x0007CE8C
		[CallerCount(308)]
		[CachedScanResults(RefRangeStart = 305128, RefRangeEnd = 305436, XrefRangeStart = 305122, XrefRangeEnd = 305128, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Delegate Combine(Delegate a, Delegate b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(b);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Delegate.NativeMethodInfoPtr_Combine_Public_Static_Delegate_Delegate_Delegate_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Delegate>(intPtr3) : null;
		}

		// Token: 0x06001438 RID: 5176 RVA: 0x0007ECE4 File Offset: 0x0007CEE4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 305444, RefRangeEnd = 305445, XrefRangeStart = 305436, XrefRangeEnd = 305444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Delegate Combine([Optional] Il2CppReferenceArray<Delegate> delegates)
		{
			if (delegates == null)
			{
				delegates = new Il2CppReferenceArray<Delegate>(0L);
			}
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(delegates);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Delegate.NativeMethodInfoPtr_Combine_Public_Static_Delegate_Il2CppReferenceArray_1_Delegate_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Delegate>(intPtr3) : null;
			}
		}

		// Token: 0x06001439 RID: 5177 RVA: 0x0007ED38 File Offset: 0x0007CF38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 305445, XrefRangeEnd = 305453, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Delegate CombineImpl(Delegate d)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(d);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Delegate.NativeMethodInfoPtr_CombineImpl_Protected_Virtual_New_Delegate_Delegate_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Delegate>(intPtr3) : null;
			}
		}

		// Token: 0x0600143A RID: 5178 RVA: 0x0007ED94 File Offset: 0x0007CF94
		[CallerCount(271)]
		[CachedScanResults(RefRangeStart = 305459, RefRangeEnd = 305730, XrefRangeStart = 305453, XrefRangeEnd = 305459, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Delegate Remove(Delegate source, Delegate value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Delegate.NativeMethodInfoPtr_Remove_Public_Static_Delegate_Delegate_Delegate_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Delegate>(intPtr3) : null;
		}

		// Token: 0x0600143B RID: 5179 RVA: 0x0007EDEC File Offset: 0x0007CFEC
		[CallerCount(0)]
		public unsafe virtual Delegate RemoveImpl(Delegate d)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(d);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Delegate.NativeMethodInfoPtr_RemoveImpl_Protected_Virtual_New_Delegate_Delegate_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Delegate>(intPtr3) : null;
			}
		}

		// Token: 0x0600143C RID: 5180 RVA: 0x0007EE48 File Offset: 0x0007D048
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 305730, RefRangeEnd = 305733, XrefRangeStart = 305730, XrefRangeEnd = 305730, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator ==(Delegate d1, Delegate d2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(d1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(d2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Delegate.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Delegate_Delegate_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600143D RID: 5181 RVA: 0x0007EE9C File Offset: 0x0007D09C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 305734, RefRangeEnd = 305739, XrefRangeStart = 305733, XrefRangeEnd = 305734, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Delegate CreateDelegateNoSecurityCheck(RuntimeType type, Object firstArgument, MethodInfo method)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(firstArgument);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(method);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Delegate.NativeMethodInfoPtr_CreateDelegateNoSecurityCheck_Internal_Static_Delegate_RuntimeType_Object_MethodInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Delegate>(intPtr3) : null;
		}

		// Token: 0x0600143E RID: 5182 RVA: 0x0007EF04 File Offset: 0x0007D104
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 305740, RefRangeEnd = 305743, XrefRangeStart = 305739, XrefRangeEnd = 305740, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static MulticastDelegate AllocDelegateLike_internal(Delegate d)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(d);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Delegate.NativeMethodInfoPtr_AllocDelegateLike_internal_Internal_Static_MulticastDelegate_Delegate_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MulticastDelegate>(intPtr3) : null;
			}
		}

		// Token: 0x0600143F RID: 5183 RVA: 0x00007086 File Offset: 0x00005286
		public static Delegate Combine(params Delegate[] delegates)
		{
			return Delegate.Combine(new Il2CppReferenceArray<Delegate>(delegates));
		}

		// Token: 0x06001440 RID: 5184 RVA: 0x00007093 File Offset: 0x00005293
		public Delegate(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003CC RID: 972
		// (get) Token: 0x06001441 RID: 5185 RVA: 0x0007EF48 File Offset: 0x0007D148
		// (set) Token: 0x06001442 RID: 5186 RVA: 0x0000709C File Offset: 0x0000529C
		public unsafe IntPtr method_ptr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Delegate.NativeFieldInfoPtr_method_ptr);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Delegate.NativeFieldInfoPtr_method_ptr)) = value;
			}
		}

		// Token: 0x170003CD RID: 973
		// (get) Token: 0x06001443 RID: 5187 RVA: 0x0007EF70 File Offset: 0x0007D170
		// (set) Token: 0x06001444 RID: 5188 RVA: 0x000070B7 File Offset: 0x000052B7
		public unsafe IntPtr invoke_impl
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Delegate.NativeFieldInfoPtr_invoke_impl);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Delegate.NativeFieldInfoPtr_invoke_impl)) = value;
			}
		}

		// Token: 0x170003CE RID: 974
		// (get) Token: 0x06001445 RID: 5189 RVA: 0x0007EF98 File Offset: 0x0007D198
		// (set) Token: 0x06001446 RID: 5190 RVA: 0x000070D2 File Offset: 0x000052D2
		public unsafe Object m_target
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Delegate.NativeFieldInfoPtr_m_target);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Delegate.NativeFieldInfoPtr_m_target), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003CF RID: 975
		// (get) Token: 0x06001447 RID: 5191 RVA: 0x0007EFC8 File Offset: 0x0007D1C8
		// (set) Token: 0x06001448 RID: 5192 RVA: 0x000070F1 File Offset: 0x000052F1
		public unsafe IntPtr method
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Delegate.NativeFieldInfoPtr_method);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Delegate.NativeFieldInfoPtr_method)) = value;
			}
		}

		// Token: 0x170003D0 RID: 976
		// (get) Token: 0x06001449 RID: 5193 RVA: 0x0007EFF0 File Offset: 0x0007D1F0
		// (set) Token: 0x0600144A RID: 5194 RVA: 0x0000710C File Offset: 0x0000530C
		public unsafe IntPtr delegate_trampoline
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Delegate.NativeFieldInfoPtr_delegate_trampoline);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Delegate.NativeFieldInfoPtr_delegate_trampoline)) = value;
			}
		}

		// Token: 0x170003D1 RID: 977
		// (get) Token: 0x0600144B RID: 5195 RVA: 0x0007F018 File Offset: 0x0007D218
		// (set) Token: 0x0600144C RID: 5196 RVA: 0x00007127 File Offset: 0x00005327
		public unsafe IntPtr extra_arg
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Delegate.NativeFieldInfoPtr_extra_arg);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Delegate.NativeFieldInfoPtr_extra_arg)) = value;
			}
		}

		// Token: 0x170003D2 RID: 978
		// (get) Token: 0x0600144D RID: 5197 RVA: 0x0007F040 File Offset: 0x0007D240
		// (set) Token: 0x0600144E RID: 5198 RVA: 0x00007142 File Offset: 0x00005342
		public unsafe IntPtr method_code
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Delegate.NativeFieldInfoPtr_method_code);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Delegate.NativeFieldInfoPtr_method_code)) = value;
			}
		}

		// Token: 0x170003D3 RID: 979
		// (get) Token: 0x0600144F RID: 5199 RVA: 0x0007F068 File Offset: 0x0007D268
		// (set) Token: 0x06001450 RID: 5200 RVA: 0x0000715D File Offset: 0x0000535D
		public unsafe MethodInfo method_info
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Delegate.NativeFieldInfoPtr_method_info);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MethodInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Delegate.NativeFieldInfoPtr_method_info), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003D4 RID: 980
		// (get) Token: 0x06001451 RID: 5201 RVA: 0x0007F098 File Offset: 0x0007D298
		// (set) Token: 0x06001452 RID: 5202 RVA: 0x0000717C File Offset: 0x0000537C
		public unsafe MethodInfo original_method_info
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Delegate.NativeFieldInfoPtr_original_method_info);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MethodInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Delegate.NativeFieldInfoPtr_original_method_info), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003D5 RID: 981
		// (get) Token: 0x06001453 RID: 5203 RVA: 0x0007F0C8 File Offset: 0x0007D2C8
		// (set) Token: 0x06001454 RID: 5204 RVA: 0x0000719B File Offset: 0x0000539B
		public unsafe DelegateData data
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Delegate.NativeFieldInfoPtr_data);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DelegateData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Delegate.NativeFieldInfoPtr_data), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003D6 RID: 982
		// (get) Token: 0x06001455 RID: 5205 RVA: 0x0007F0F8 File Offset: 0x0007D2F8
		// (set) Token: 0x06001456 RID: 5206 RVA: 0x000071BA File Offset: 0x000053BA
		public unsafe bool method_is_virtual
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Delegate.NativeFieldInfoPtr_method_is_virtual);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Delegate.NativeFieldInfoPtr_method_is_virtual)) = value;
			}
		}

		// Token: 0x04001132 RID: 4402
		private static readonly IntPtr NativeFieldInfoPtr_method_ptr;

		// Token: 0x04001133 RID: 4403
		private static readonly IntPtr NativeFieldInfoPtr_invoke_impl;

		// Token: 0x04001134 RID: 4404
		private static readonly IntPtr NativeFieldInfoPtr_m_target;

		// Token: 0x04001135 RID: 4405
		private static readonly IntPtr NativeFieldInfoPtr_method;

		// Token: 0x04001136 RID: 4406
		private static readonly IntPtr NativeFieldInfoPtr_delegate_trampoline;

		// Token: 0x04001137 RID: 4407
		private static readonly IntPtr NativeFieldInfoPtr_extra_arg;

		// Token: 0x04001138 RID: 4408
		private static readonly IntPtr NativeFieldInfoPtr_method_code;

		// Token: 0x04001139 RID: 4409
		private static readonly IntPtr NativeFieldInfoPtr_method_info;

		// Token: 0x0400113A RID: 4410
		private static readonly IntPtr NativeFieldInfoPtr_original_method_info;

		// Token: 0x0400113B RID: 4411
		private static readonly IntPtr NativeFieldInfoPtr_data;

		// Token: 0x0400113C RID: 4412
		private static readonly IntPtr NativeFieldInfoPtr_method_is_virtual;

		// Token: 0x0400113D RID: 4413
		private static readonly IntPtr NativeMethodInfoPtr_get_Method_Public_get_MethodInfo_0;

		// Token: 0x0400113E RID: 4414
		private static readonly IntPtr NativeMethodInfoPtr_GetVirtualMethod_internal_Private_MethodInfo_0;

		// Token: 0x0400113F RID: 4415
		private static readonly IntPtr NativeMethodInfoPtr_get_Target_Public_get_Object_0;

		// Token: 0x04001140 RID: 4416
		private static readonly IntPtr NativeMethodInfoPtr_CreateDelegate_internal_Internal_Static_Delegate_Type_Object_MethodInfo_Boolean_0;

		// Token: 0x04001141 RID: 4417
		private static readonly IntPtr NativeMethodInfoPtr_arg_type_match_Private_Static_Boolean_Type_Type_0;

		// Token: 0x04001142 RID: 4418
		private static readonly IntPtr NativeMethodInfoPtr_arg_type_match_this_Private_Static_Boolean_Type_Type_Boolean_0;

		// Token: 0x04001143 RID: 4419
		private static readonly IntPtr NativeMethodInfoPtr_return_type_match_Private_Static_Boolean_Type_Type_0;

		// Token: 0x04001144 RID: 4420
		private static readonly IntPtr NativeMethodInfoPtr_CreateDelegate_Public_Static_Delegate_Type_Object_MethodInfo_Boolean_0;

		// Token: 0x04001145 RID: 4421
		private static readonly IntPtr NativeMethodInfoPtr_CreateDelegate_Private_Static_Delegate_Type_Object_MethodInfo_Boolean_Boolean_0;

		// Token: 0x04001146 RID: 4422
		private static readonly IntPtr NativeMethodInfoPtr_CreateDelegate_Public_Static_Delegate_Type_Object_MethodInfo_0;

		// Token: 0x04001147 RID: 4423
		private static readonly IntPtr NativeMethodInfoPtr_CreateDelegate_Public_Static_Delegate_Type_MethodInfo_Boolean_0;

		// Token: 0x04001148 RID: 4424
		private static readonly IntPtr NativeMethodInfoPtr_CreateDelegate_Public_Static_Delegate_Type_MethodInfo_0;

		// Token: 0x04001149 RID: 4425
		private static readonly IntPtr NativeMethodInfoPtr_CreateDelegate_Public_Static_Delegate_Type_Object_String_0;

		// Token: 0x0400114A RID: 4426
		private static readonly IntPtr NativeMethodInfoPtr_GetCandidateMethod_Private_Static_MethodInfo_Type_Type_String_BindingFlags_Boolean_Boolean_0;

		// Token: 0x0400114B RID: 4427
		private static readonly IntPtr NativeMethodInfoPtr_CreateDelegate_Public_Static_Delegate_Type_Type_String_Boolean_Boolean_0;

		// Token: 0x0400114C RID: 4428
		private static readonly IntPtr NativeMethodInfoPtr_CreateDelegate_Public_Static_Delegate_Type_Type_String_0;

		// Token: 0x0400114D RID: 4429
		private static readonly IntPtr NativeMethodInfoPtr_CreateDelegate_Public_Static_Delegate_Type_Object_String_Boolean_Boolean_0;

		// Token: 0x0400114E RID: 4430
		private static readonly IntPtr NativeMethodInfoPtr_CreateDelegate_Public_Static_Delegate_Type_Object_String_Boolean_0;

		// Token: 0x0400114F RID: 4431
		private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_Virtual_New_Object_0;

		// Token: 0x04001150 RID: 4432
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04001151 RID: 4433
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04001152 RID: 4434
		private static readonly IntPtr NativeMethodInfoPtr_GetMethodImpl_Protected_Virtual_New_MethodInfo_0;

		// Token: 0x04001153 RID: 4435
		private static readonly IntPtr NativeMethodInfoPtr_GetObjectData_Public_Virtual_New_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x04001154 RID: 4436
		private static readonly IntPtr NativeMethodInfoPtr_GetInvocationList_Public_Virtual_New_Il2CppReferenceArray_1_Delegate_0;

		// Token: 0x04001155 RID: 4437
		private static readonly IntPtr NativeMethodInfoPtr_Combine_Public_Static_Delegate_Delegate_Delegate_0;

		// Token: 0x04001156 RID: 4438
		private static readonly IntPtr NativeMethodInfoPtr_Combine_Public_Static_Delegate_Il2CppReferenceArray_1_Delegate_0;

		// Token: 0x04001157 RID: 4439
		private static readonly IntPtr NativeMethodInfoPtr_CombineImpl_Protected_Virtual_New_Delegate_Delegate_0;

		// Token: 0x04001158 RID: 4440
		private static readonly IntPtr NativeMethodInfoPtr_Remove_Public_Static_Delegate_Delegate_Delegate_0;

		// Token: 0x04001159 RID: 4441
		private static readonly IntPtr NativeMethodInfoPtr_RemoveImpl_Protected_Virtual_New_Delegate_Delegate_0;

		// Token: 0x0400115A RID: 4442
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Delegate_Delegate_0;

		// Token: 0x0400115B RID: 4443
		private static readonly IntPtr NativeMethodInfoPtr_CreateDelegateNoSecurityCheck_Internal_Static_Delegate_RuntimeType_Object_MethodInfo_0;

		// Token: 0x0400115C RID: 4444
		private static readonly IntPtr NativeMethodInfoPtr_AllocDelegateLike_internal_Internal_Static_MulticastDelegate_Delegate_0;
	}
}
