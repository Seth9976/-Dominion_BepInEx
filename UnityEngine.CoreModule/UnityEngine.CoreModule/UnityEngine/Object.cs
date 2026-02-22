using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Reflection;

namespace UnityEngine
{
	// Token: 0x020000C5 RID: 197
	public class Object : Object
	{
		// Token: 0x06001123 RID: 4387 RVA: 0x00045BA4 File Offset: 0x00043DA4
		// Note: this type is marked as 'beforefieldinit'.
		static Object()
		{
			Il2CppClassPointerStore<Object>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "Object");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Object>.NativeClassPtr);
			Object.NativeFieldInfoPtr_m_CachedPtr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Object>.NativeClassPtr, "m_CachedPtr");
			Object.NativeFieldInfoPtr_OffsetOfInstanceIDInCPlusPlusObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Object>.NativeClassPtr, "OffsetOfInstanceIDInCPlusPlusObject");
			Object.NativeFieldInfoPtr_objectIsNullMessage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Object>.NativeClassPtr, "objectIsNullMessage");
			Object.NativeFieldInfoPtr_cloneDestroyedMessage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Object>.NativeClassPtr, "cloneDestroyedMessage");
			Object.NativeMethodInfoPtr_GetInstanceID_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100664477);
			Object.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100664478);
			Object.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100664479);
			Object.NativeMethodInfoPtr_op_Implicit_Public_Static_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100664480);
			Object.NativeMethodInfoPtr_CompareBaseObjects_Private_Static_Boolean_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100664481);
			Object.NativeMethodInfoPtr_IsNativeObjectAlive_Private_Static_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100664482);
			Object.NativeMethodInfoPtr_GetCachedPtr_Private_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100664483);
			Object.NativeMethodInfoPtr_get_name_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100664484);
			Object.NativeMethodInfoPtr_set_name_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100664485);
			Object.NativeMethodInfoPtr_Instantiate_Public_Static_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100664486);
			Object.NativeMethodInfoPtr_Instantiate_Public_Static_Object_Object_Transform_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100664487);
			Object.NativeMethodInfoPtr_Instantiate_Public_Static_T_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100664488);
			Object.NativeMethodInfoPtr_Instantiate_Public_Static_T_T_Transform_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100664489);
			Object.NativeMethodInfoPtr_Destroy_Public_Static_Void_Object_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100664490);
			Object.NativeMethodInfoPtr_Destroy_Public_Static_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100664491);
			Object.NativeMethodInfoPtr_DestroyImmediate_Public_Static_Void_Object_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100664492);
			Object.NativeMethodInfoPtr_DestroyImmediate_Public_Static_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100664493);
			Object.NativeMethodInfoPtr_FindObjectsOfType_Public_Static_Il2CppReferenceArray_1_Object_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100664494);
			Object.NativeMethodInfoPtr_FindObjectsOfType_Public_Static_Il2CppReferenceArray_1_Object_Type_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100664495);
			Object.NativeMethodInfoPtr_DontDestroyOnLoad_Public_Static_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100664496);
			Object.NativeMethodInfoPtr_get_hideFlags_Public_get_HideFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100664497);
			Object.NativeMethodInfoPtr_set_hideFlags_Public_set_Void_HideFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100664498);
			Object.NativeMethodInfoPtr_FindObjectOfType_Public_Static_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100664499);
			Object.NativeMethodInfoPtr_CheckNullArgument_Private_Static_Void_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100664500);
			Object.NativeMethodInfoPtr_FindObjectOfType_Public_Static_Object_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100664501);
			Object.NativeMethodInfoPtr_FindObjectOfType_Public_Static_Object_Type_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100664502);
			Object.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100664503);
			Object.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100664504);
			Object.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100664505);
			Object.NativeMethodInfoPtr_GetOffsetOfInstanceIDInCPlusPlusObject_Private_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100664506);
			Object.NativeMethodInfoPtr_Internal_CloneSingle_Private_Static_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100664507);
			Object.NativeMethodInfoPtr_Internal_CloneSingleWithParent_Private_Static_Object_Object_Transform_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100664508);
			Object.NativeMethodInfoPtr_ToString_Private_Static_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100664509);
			Object.NativeMethodInfoPtr_GetName_Private_Static_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100664510);
			Object.NativeMethodInfoPtr_SetName_Private_Static_Void_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100664511);
			Object.NativeMethodInfoPtr_FindObjectFromInstanceID_Internal_Static_Object_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100664512);
			Object.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100664513);
			Object.FindObjectsOfTypeIncludingAssetsDelegateField = IL2CPP.ResolveICall<Object.FindObjectsOfTypeIncludingAssetsDelegate>("UnityEngine.Object::FindObjectsOfTypeIncludingAssets");
			Object.CurrentThreadIsMainThreadDelegateField = IL2CPP.ResolveICall<Object.CurrentThreadIsMainThreadDelegate>("UnityEngine.Object::CurrentThreadIsMainThread");
			Object.IsPersistentDelegateField = IL2CPP.ResolveICall<Object.IsPersistentDelegate>("UnityEngine.Object::IsPersistent");
			Object.DoesObjectWithInstanceIDExistDelegateField = IL2CPP.ResolveICall<Object.DoesObjectWithInstanceIDExistDelegate>("UnityEngine.Object::DoesObjectWithInstanceIDExist");
			Object.ForceLoadFromInstanceIDDelegateField = IL2CPP.ResolveICall<Object.ForceLoadFromInstanceIDDelegate>("UnityEngine.Object::ForceLoadFromInstanceID");
			Object.Internal_InstantiateSingle_InjectedDelegateField = IL2CPP.ResolveICall<Object.Internal_InstantiateSingle_InjectedDelegate>("UnityEngine.Object::Internal_InstantiateSingle_Injected");
			Object.Internal_InstantiateSingleWithParent_InjectedDelegateField = IL2CPP.ResolveICall<Object.Internal_InstantiateSingleWithParent_InjectedDelegate>("UnityEngine.Object::Internal_InstantiateSingleWithParent_Injected");
		}

		// Token: 0x06001124 RID: 4388 RVA: 0x00045F74 File Offset: 0x00044174
		[CallerCount(130)]
		[CachedScanResults(RefRangeStart = 72656, RefRangeEnd = 72786, XrefRangeStart = 72640, XrefRangeEnd = 72656, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetInstanceID()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Object.NativeMethodInfoPtr_GetInstanceID_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001125 RID: 4389 RVA: 0x00045FB0 File Offset: 0x000441B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72786, XrefRangeEnd = 72787, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Object.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001126 RID: 4390 RVA: 0x00045FF8 File Offset: 0x000441F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72787, XrefRangeEnd = 72817, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Object.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001127 RID: 4391 RVA: 0x00046050 File Offset: 0x00044250
		[CallerCount(177)]
		[CachedScanResults(RefRangeStart = 72826, RefRangeEnd = 73003, XrefRangeStart = 72817, XrefRangeEnd = 72826, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator bool(Object exists)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(exists);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Object.NativeMethodInfoPtr_op_Implicit_Public_Static_Boolean_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001128 RID: 4392 RVA: 0x00046094 File Offset: 0x00044294
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73003, XrefRangeEnd = 73004, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool CompareBaseObjects(Object lhs, Object rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(lhs);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rhs);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Object.NativeMethodInfoPtr_CompareBaseObjects_Private_Static_Boolean_Object_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001129 RID: 4393 RVA: 0x000460E8 File Offset: 0x000442E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73004, XrefRangeEnd = 73007, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsNativeObjectAlive(Object o)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(o);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Object.NativeMethodInfoPtr_IsNativeObjectAlive_Private_Static_Boolean_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600112A RID: 4394 RVA: 0x0004612C File Offset: 0x0004432C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 58949, RefRangeEnd = 58951, XrefRangeStart = 58949, XrefRangeEnd = 58951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IntPtr GetCachedPtr()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Object.NativeMethodInfoPtr_GetCachedPtr_Private_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000388 RID: 904
		// (get) Token: 0x0600112B RID: 4395 RVA: 0x00046168 File Offset: 0x00044368
		// (set) Token: 0x0600112C RID: 4396 RVA: 0x000461A0 File Offset: 0x000443A0
		public unsafe string name
		{
			[CallerCount(75)]
			[CachedScanResults(RefRangeStart = 73012, RefRangeEnd = 73087, XrefRangeStart = 73007, XrefRangeEnd = 73012, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Object.NativeMethodInfoPtr_get_name_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(33)]
			[CachedScanResults(RefRangeStart = 73092, RefRangeEnd = 73125, XrefRangeStart = 73087, XrefRangeEnd = 73092, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Object.NativeMethodInfoPtr_set_name_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600112D RID: 4397 RVA: 0x000461E4 File Offset: 0x000443E4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 73141, RefRangeEnd = 73145, XrefRangeStart = 73125, XrefRangeEnd = 73141, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object Instantiate(Object original)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(original);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Object.NativeMethodInfoPtr_Instantiate_Public_Static_Object_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x0600112E RID: 4398 RVA: 0x00046228 File Offset: 0x00044428
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 73176, RefRangeEnd = 73177, XrefRangeStart = 73145, XrefRangeEnd = 73176, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object Instantiate(Object original, Transform parent, bool instantiateInWorldSpace)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(original);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref instantiateInWorldSpace;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Object.NativeMethodInfoPtr_Instantiate_Public_Static_Object_Object_Transform_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x0600112F RID: 4399 RVA: 0x0004628C File Offset: 0x0004448C
		[CallerCount(37)]
		[CachedScanResults(RefRangeStart = 73188, RefRangeEnd = 73225, XrefRangeStart = 73177, XrefRangeEnd = 73188, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T Instantiate<T>(T original) where T : Object
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t = original;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref original;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Object.MethodInfoStoreGeneric_Instantiate_Public_Static_T_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				return IL2CPP.PointerToValueGeneric<T>(intPtr2, false, true);
			}
		}

		// Token: 0x06001130 RID: 4400 RVA: 0x00046300 File Offset: 0x00044500
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 73230, RefRangeEnd = 73233, XrefRangeStart = 73225, XrefRangeEnd = 73230, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T Instantiate<T>(T original, Transform parent, bool worldPositionStays) where T : Object
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t = original;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref original;
				}
				ptr2 = intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref worldPositionStays;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Object.MethodInfoStoreGeneric_Instantiate_Public_Static_T_T_Transform_Boolean_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			return IL2CPP.PointerToValueGeneric<T>(intPtr2, false, true);
		}

		// Token: 0x06001131 RID: 4401 RVA: 0x00046394 File Offset: 0x00044594
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 73235, RefRangeEnd = 73236, XrefRangeStart = 73233, XrefRangeEnd = 73235, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Destroy(Object obj, float t)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref t;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Object.NativeMethodInfoPtr_Destroy_Public_Static_Void_Object_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001132 RID: 4402 RVA: 0x000463D8 File Offset: 0x000445D8
		[CallerCount(70)]
		[CachedScanResults(RefRangeStart = 73241, RefRangeEnd = 73311, XrefRangeStart = 73236, XrefRangeEnd = 73241, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Destroy(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Object.NativeMethodInfoPtr_Destroy_Public_Static_Void_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001133 RID: 4403 RVA: 0x00046410 File Offset: 0x00044610
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 73313, RefRangeEnd = 73314, XrefRangeStart = 73311, XrefRangeEnd = 73313, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DestroyImmediate(Object obj, bool allowDestroyingAssets)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref allowDestroyingAssets;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Object.NativeMethodInfoPtr_DestroyImmediate_Public_Static_Void_Object_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001134 RID: 4404 RVA: 0x00046454 File Offset: 0x00044654
		[CallerCount(34)]
		[CachedScanResults(RefRangeStart = 73319, RefRangeEnd = 73353, XrefRangeStart = 73314, XrefRangeEnd = 73319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DestroyImmediate(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Object.NativeMethodInfoPtr_DestroyImmediate_Public_Static_Void_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001135 RID: 4405 RVA: 0x0004648C File Offset: 0x0004468C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 73358, RefRangeEnd = 73359, XrefRangeStart = 73353, XrefRangeEnd = 73358, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppReferenceArray<Object> FindObjectsOfType(Type type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Object.NativeMethodInfoPtr_FindObjectsOfType_Public_Static_Il2CppReferenceArray_1_Object_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr3) : null;
			}
		}

		// Token: 0x06001136 RID: 4406 RVA: 0x000464D0 File Offset: 0x000446D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73359, XrefRangeEnd = 73361, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppReferenceArray<Object> FindObjectsOfType(Type type, bool includeInactive)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref includeInactive;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Object.NativeMethodInfoPtr_FindObjectsOfType_Public_Static_Il2CppReferenceArray_1_Object_Type_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr3) : null;
		}

		// Token: 0x06001137 RID: 4407 RVA: 0x00046524 File Offset: 0x00044724
		[CallerCount(65)]
		[CachedScanResults(RefRangeStart = 73363, RefRangeEnd = 73428, XrefRangeStart = 73361, XrefRangeEnd = 73363, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DontDestroyOnLoad(Object target)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Object.NativeMethodInfoPtr_DontDestroyOnLoad_Public_Static_Void_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000389 RID: 905
		// (get) Token: 0x06001138 RID: 4408 RVA: 0x0004655C File Offset: 0x0004475C
		// (set) Token: 0x06001139 RID: 4409 RVA: 0x00046598 File Offset: 0x00044798
		public unsafe HideFlags hideFlags
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 73430, RefRangeEnd = 73432, XrefRangeStart = 73428, XrefRangeEnd = 73430, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Object.NativeMethodInfoPtr_get_hideFlags_Public_get_HideFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(24)]
			[CachedScanResults(RefRangeStart = 73434, RefRangeEnd = 73458, XrefRangeStart = 73432, XrefRangeEnd = 73434, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Object.NativeMethodInfoPtr_set_hideFlags_Public_set_Void_HideFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600113A RID: 4410 RVA: 0x000465D8 File Offset: 0x000447D8
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 73467, RefRangeEnd = 73477, XrefRangeStart = 73458, XrefRangeEnd = 73467, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T FindObjectOfType<T>() where T : Object
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Object.MethodInfoStoreGeneric_FindObjectOfType_Public_Static_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x0600113B RID: 4411 RVA: 0x00046608 File Offset: 0x00044808
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 73477, RefRangeEnd = 73478, XrefRangeStart = 73477, XrefRangeEnd = 73477, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CheckNullArgument(Object arg, string message)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(arg);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(message);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Object.NativeMethodInfoPtr_CheckNullArgument_Private_Static_Void_Object_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600113C RID: 4412 RVA: 0x00046650 File Offset: 0x00044850
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 73483, RefRangeEnd = 73490, XrefRangeStart = 73478, XrefRangeEnd = 73483, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object FindObjectOfType(Type type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Object.NativeMethodInfoPtr_FindObjectOfType_Public_Static_Object_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x0600113D RID: 4413 RVA: 0x00046694 File Offset: 0x00044894
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 73495, RefRangeEnd = 73496, XrefRangeStart = 73490, XrefRangeEnd = 73495, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object FindObjectOfType(Type type, bool includeInactive)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref includeInactive;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Object.NativeMethodInfoPtr_FindObjectOfType_Public_Static_Object_Type_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x0600113E RID: 4414 RVA: 0x000466E8 File Offset: 0x000448E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73496, XrefRangeEnd = 73501, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Object.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600113F RID: 4415 RVA: 0x0004672C File Offset: 0x0004492C
		[CallerCount(892)]
		[CachedScanResults(RefRangeStart = 73507, RefRangeEnd = 74399, XrefRangeStart = 73501, XrefRangeEnd = 73507, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator ==(Object x, Object y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(y);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Object.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Object_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001140 RID: 4416 RVA: 0x00046780 File Offset: 0x00044980
		[CallerCount(2057)]
		[CachedScanResults(RefRangeStart = 74405, RefRangeEnd = 76462, XrefRangeStart = 74399, XrefRangeEnd = 74405, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator !=(Object x, Object y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(y);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Object.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Object_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001141 RID: 4417 RVA: 0x000467D4 File Offset: 0x000449D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76462, XrefRangeEnd = 76464, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetOffsetOfInstanceIDInCPlusPlusObject()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Object.NativeMethodInfoPtr_GetOffsetOfInstanceIDInCPlusPlusObject_Private_Static_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001142 RID: 4418 RVA: 0x00046804 File Offset: 0x00044A04
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 76466, RefRangeEnd = 76467, XrefRangeStart = 76464, XrefRangeEnd = 76466, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object Internal_CloneSingle(Object data)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Object.NativeMethodInfoPtr_Internal_CloneSingle_Private_Static_Object_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06001143 RID: 4419 RVA: 0x00046848 File Offset: 0x00044A48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76467, XrefRangeEnd = 76469, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object Internal_CloneSingleWithParent(Object data, Transform parent, bool worldPositionStays)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref worldPositionStays;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Object.NativeMethodInfoPtr_Internal_CloneSingleWithParent_Private_Static_Object_Object_Transform_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06001144 RID: 4420 RVA: 0x000468AC File Offset: 0x00044AAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76469, XrefRangeEnd = 76473, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ToString(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Object.NativeMethodInfoPtr_ToString_Private_Static_String_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001145 RID: 4421 RVA: 0x000468E8 File Offset: 0x00044AE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76473, XrefRangeEnd = 76475, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetName(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Object.NativeMethodInfoPtr_GetName_Private_Static_String_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001146 RID: 4422 RVA: 0x00046924 File Offset: 0x00044B24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76475, XrefRangeEnd = 76477, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetName(Object obj, string name)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Object.NativeMethodInfoPtr_SetName_Private_Static_Void_Object_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001147 RID: 4423 RVA: 0x0004696C File Offset: 0x00044B6C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 76479, RefRangeEnd = 76481, XrefRangeStart = 76477, XrefRangeEnd = 76479, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object FindObjectFromInstanceID(int instanceID)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref instanceID;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Object.NativeMethodInfoPtr_FindObjectFromInstanceID_Internal_Static_Object_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06001148 RID: 4424 RVA: 0x000469AC File Offset: 0x00044BAC
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Object>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Object.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001149 RID: 4425 RVA: 0x0000A616 File Offset: 0x00008816
		public Object(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000384 RID: 900
		// (get) Token: 0x0600114A RID: 4426 RVA: 0x000469E8 File Offset: 0x00044BE8
		// (set) Token: 0x0600114B RID: 4427 RVA: 0x0000A61F File Offset: 0x0000881F
		public unsafe IntPtr m_CachedPtr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Object.NativeFieldInfoPtr_m_CachedPtr);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Object.NativeFieldInfoPtr_m_CachedPtr)) = value;
			}
		}

		// Token: 0x17000385 RID: 901
		// (get) Token: 0x0600114C RID: 4428 RVA: 0x00046A10 File Offset: 0x00044C10
		// (set) Token: 0x0600114D RID: 4429 RVA: 0x0000A63A File Offset: 0x0000883A
		public unsafe static int OffsetOfInstanceIDInCPlusPlusObject
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Object.NativeFieldInfoPtr_OffsetOfInstanceIDInCPlusPlusObject, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Object.NativeFieldInfoPtr_OffsetOfInstanceIDInCPlusPlusObject, (void*)(&value));
			}
		}

		// Token: 0x17000386 RID: 902
		// (get) Token: 0x0600114E RID: 4430 RVA: 0x00046A2C File Offset: 0x00044C2C
		// (set) Token: 0x0600114F RID: 4431 RVA: 0x0000A648 File Offset: 0x00008848
		public unsafe static string objectIsNullMessage
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Object.NativeFieldInfoPtr_objectIsNullMessage, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Object.NativeFieldInfoPtr_objectIsNullMessage, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000387 RID: 903
		// (get) Token: 0x06001150 RID: 4432 RVA: 0x00046A4C File Offset: 0x00044C4C
		// (set) Token: 0x06001151 RID: 4433 RVA: 0x0000A65A File Offset: 0x0000885A
		public unsafe static string cloneDestroyedMessage
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Object.NativeFieldInfoPtr_cloneDestroyedMessage, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Object.NativeFieldInfoPtr_cloneDestroyedMessage, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x06001152 RID: 4434 RVA: 0x00046A6C File Offset: 0x00044C6C
		public void EnsureRunningOnMainThread()
		{
			bool flag = !Object.CurrentThreadIsMainThread();
			if (flag)
			{
				throw new InvalidOperationException("EnsureRunningOnMainThread can only be called from the main thread");
			}
		}

		// Token: 0x06001153 RID: 4435 RVA: 0x00046A94 File Offset: 0x00044C94
		public static Object Instantiate(Object original, Vector3 position, Quaternion rotation)
		{
			Object.CheckNullArgument(original, "The Object you want to instantiate is null.");
			bool flag = original.TryCast<ScriptableObject>() != null;
			if (flag)
			{
				throw new ArgumentException("Cannot instantiate a ScriptableObject with a position and rotation");
			}
			Object @object = Object.Internal_InstantiateSingle(original, position, rotation);
			bool flag2 = @object == null;
			if (flag2)
			{
				throw new UnityException("Instantiate failed because the clone was destroyed during creation. This can happen if DestroyImmediate is called in MonoBehaviour.Awake.");
			}
			return @object;
		}

		// Token: 0x06001154 RID: 4436 RVA: 0x00046AEC File Offset: 0x00044CEC
		public static Object Instantiate(Object original, Vector3 position, Quaternion rotation, Transform parent)
		{
			bool flag = parent == null;
			Object @object;
			if (flag)
			{
				@object = Object.Instantiate(original, position, rotation);
			}
			else
			{
				Object.CheckNullArgument(original, "The Object you want to instantiate is null.");
				Object object2 = Object.Internal_InstantiateSingleWithParent(original, parent, position, rotation);
				bool flag2 = object2 == null;
				if (flag2)
				{
					throw new UnityException("Instantiate failed because the clone was destroyed during creation. This can happen if DestroyImmediate is called in MonoBehaviour.Awake.");
				}
				@object = object2;
			}
			return @object;
		}

		// Token: 0x06001155 RID: 4437 RVA: 0x00046B44 File Offset: 0x00044D44
		public static Object Instantiate(Object original, Transform parent)
		{
			return Object.Instantiate(original, parent, false);
		}

		// Token: 0x06001156 RID: 4438 RVA: 0x00046B60 File Offset: 0x00044D60
		public static T Instantiate<T>(T original, Vector3 position, Quaternion rotation) where T : Object
		{
			return Object.Instantiate(original, position, rotation).Cast<T>();
		}

		// Token: 0x06001157 RID: 4439 RVA: 0x00046B84 File Offset: 0x00044D84
		public static T Instantiate<T>(T original, Vector3 position, Quaternion rotation, Transform parent) where T : Object
		{
			return Object.Instantiate(original, position, rotation, parent).Cast<T>();
		}

		// Token: 0x06001158 RID: 4440 RVA: 0x00046BAC File Offset: 0x00044DAC
		public static T Instantiate<T>(T original, Transform parent) where T : Object
		{
			return Object.Instantiate<T>(original, parent, false);
		}

		// Token: 0x06001159 RID: 4441 RVA: 0x0000A66C File Offset: 0x0000886C
		public static void DestroyObject(Object obj, float t)
		{
			Object.Destroy(obj, t);
		}

		// Token: 0x0600115A RID: 4442 RVA: 0x00046BC8 File Offset: 0x00044DC8
		public static void DestroyObject(Object obj)
		{
			float num = 0f;
			Object.Destroy(obj, num);
		}

		// Token: 0x0600115B RID: 4443 RVA: 0x00046BE4 File Offset: 0x00044DE4
		public static Il2CppReferenceArray<Object> FindSceneObjectsOfType(Type type)
		{
			return Object.FindObjectsOfType(type);
		}

		// Token: 0x0600115C RID: 4444 RVA: 0x00046BFC File Offset: 0x00044DFC
		public static Il2CppReferenceArray<Object> FindObjectsOfTypeIncludingAssets(Type type)
		{
			IntPtr intPtr = Object.FindObjectsOfTypeIncludingAssetsDelegateField(IL2CPP.Il2CppObjectBaseToPtr(type));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr2) : null;
		}

		// Token: 0x0600115D RID: 4445 RVA: 0x00046C28 File Offset: 0x00044E28
		public static Il2CppArrayBase<T> FindObjectsOfType<T>() where T : Object
		{
			return Resources.ConvertObjects<T>(Object.FindObjectsOfType(Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>()), false));
		}

		// Token: 0x0600115E RID: 4446 RVA: 0x00046C50 File Offset: 0x00044E50
		public static Il2CppArrayBase<T> FindObjectsOfType<T>(bool includeInactive) where T : Object
		{
			return Resources.ConvertObjects<T>(Object.FindObjectsOfType(Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>()), includeInactive));
		}

		// Token: 0x0600115F RID: 4447 RVA: 0x00046C78 File Offset: 0x00044E78
		public static T FindObjectOfType<T>(bool includeInactive) where T : Object
		{
			return Object.FindObjectOfType(Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>()), includeInactive).Cast<T>();
		}

		// Token: 0x06001160 RID: 4448 RVA: 0x00046CA0 File Offset: 0x00044EA0
		public static Il2CppReferenceArray<Object> FindObjectsOfTypeAll(Type type)
		{
			return Resources.FindObjectsOfTypeAll(type);
		}

		// Token: 0x06001161 RID: 4449 RVA: 0x0000A677 File Offset: 0x00008877
		public static bool CurrentThreadIsMainThread()
		{
			return Object.CurrentThreadIsMainThreadDelegateField();
		}

		// Token: 0x06001162 RID: 4450 RVA: 0x0000A683 File Offset: 0x00008883
		public static Object Internal_InstantiateSingle(Object data, Vector3 pos, Quaternion rot)
		{
			return Object.Internal_InstantiateSingle_Injected(data, ref pos, ref rot);
		}

		// Token: 0x06001163 RID: 4451 RVA: 0x0000A68F File Offset: 0x0000888F
		public static Object Internal_InstantiateSingleWithParent(Object data, Transform parent, Vector3 pos, Quaternion rot)
		{
			return Object.Internal_InstantiateSingleWithParent_Injected(data, parent, ref pos, ref rot);
		}

		// Token: 0x06001164 RID: 4452 RVA: 0x0000A69C File Offset: 0x0000889C
		public static bool IsPersistent(Object obj)
		{
			return Object.IsPersistentDelegateField(IL2CPP.Il2CppObjectBaseToPtr(obj));
		}

		// Token: 0x06001165 RID: 4453 RVA: 0x0000A6AE File Offset: 0x000088AE
		public static bool DoesObjectWithInstanceIDExist(int instanceID)
		{
			return Object.DoesObjectWithInstanceIDExistDelegateField(instanceID);
		}

		// Token: 0x06001166 RID: 4454 RVA: 0x00046CB8 File Offset: 0x00044EB8
		public static Object ForceLoadFromInstanceID(int instanceID)
		{
			IntPtr intPtr = Object.ForceLoadFromInstanceIDDelegateField(instanceID);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
		}

		// Token: 0x06001167 RID: 4455 RVA: 0x00046CE0 File Offset: 0x00044EE0
		public static Object Internal_InstantiateSingle_Injected(Object data, ref Vector3 pos, ref Quaternion rot)
		{
			IntPtr intPtr = Object.Internal_InstantiateSingle_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtr(data), ref pos, ref rot);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
		}

		// Token: 0x06001168 RID: 4456 RVA: 0x00046D10 File Offset: 0x00044F10
		public static Object Internal_InstantiateSingleWithParent_Injected(Object data, Transform parent, ref Vector3 pos, ref Quaternion rot)
		{
			IntPtr intPtr = Object.Internal_InstantiateSingleWithParent_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtr(data), IL2CPP.Il2CppObjectBaseToPtr(parent), ref pos, ref rot);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
		}

		// Token: 0x04000CED RID: 3309
		private static readonly IntPtr NativeFieldInfoPtr_m_CachedPtr;

		// Token: 0x04000CEE RID: 3310
		private static readonly IntPtr NativeFieldInfoPtr_OffsetOfInstanceIDInCPlusPlusObject;

		// Token: 0x04000CEF RID: 3311
		private static readonly IntPtr NativeFieldInfoPtr_objectIsNullMessage;

		// Token: 0x04000CF0 RID: 3312
		private static readonly IntPtr NativeFieldInfoPtr_cloneDestroyedMessage;

		// Token: 0x04000CF1 RID: 3313
		private static readonly IntPtr NativeMethodInfoPtr_GetInstanceID_Public_Int32_0;

		// Token: 0x04000CF2 RID: 3314
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04000CF3 RID: 3315
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04000CF4 RID: 3316
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_Boolean_Object_0;

		// Token: 0x04000CF5 RID: 3317
		private static readonly IntPtr NativeMethodInfoPtr_CompareBaseObjects_Private_Static_Boolean_Object_Object_0;

		// Token: 0x04000CF6 RID: 3318
		private static readonly IntPtr NativeMethodInfoPtr_IsNativeObjectAlive_Private_Static_Boolean_Object_0;

		// Token: 0x04000CF7 RID: 3319
		private static readonly IntPtr NativeMethodInfoPtr_GetCachedPtr_Private_IntPtr_0;

		// Token: 0x04000CF8 RID: 3320
		private static readonly IntPtr NativeMethodInfoPtr_get_name_Public_get_String_0;

		// Token: 0x04000CF9 RID: 3321
		private static readonly IntPtr NativeMethodInfoPtr_set_name_Public_set_Void_String_0;

		// Token: 0x04000CFA RID: 3322
		private static readonly IntPtr NativeMethodInfoPtr_Instantiate_Public_Static_Object_Object_0;

		// Token: 0x04000CFB RID: 3323
		private static readonly IntPtr NativeMethodInfoPtr_Instantiate_Public_Static_Object_Object_Transform_Boolean_0;

		// Token: 0x04000CFC RID: 3324
		private static readonly IntPtr NativeMethodInfoPtr_Instantiate_Public_Static_T_T_0;

		// Token: 0x04000CFD RID: 3325
		private static readonly IntPtr NativeMethodInfoPtr_Instantiate_Public_Static_T_T_Transform_Boolean_0;

		// Token: 0x04000CFE RID: 3326
		private static readonly IntPtr NativeMethodInfoPtr_Destroy_Public_Static_Void_Object_Single_0;

		// Token: 0x04000CFF RID: 3327
		private static readonly IntPtr NativeMethodInfoPtr_Destroy_Public_Static_Void_Object_0;

		// Token: 0x04000D00 RID: 3328
		private static readonly IntPtr NativeMethodInfoPtr_DestroyImmediate_Public_Static_Void_Object_Boolean_0;

		// Token: 0x04000D01 RID: 3329
		private static readonly IntPtr NativeMethodInfoPtr_DestroyImmediate_Public_Static_Void_Object_0;

		// Token: 0x04000D02 RID: 3330
		private static readonly IntPtr NativeMethodInfoPtr_FindObjectsOfType_Public_Static_Il2CppReferenceArray_1_Object_Type_0;

		// Token: 0x04000D03 RID: 3331
		private static readonly IntPtr NativeMethodInfoPtr_FindObjectsOfType_Public_Static_Il2CppReferenceArray_1_Object_Type_Boolean_0;

		// Token: 0x04000D04 RID: 3332
		private static readonly IntPtr NativeMethodInfoPtr_DontDestroyOnLoad_Public_Static_Void_Object_0;

		// Token: 0x04000D05 RID: 3333
		private static readonly IntPtr NativeMethodInfoPtr_get_hideFlags_Public_get_HideFlags_0;

		// Token: 0x04000D06 RID: 3334
		private static readonly IntPtr NativeMethodInfoPtr_set_hideFlags_Public_set_Void_HideFlags_0;

		// Token: 0x04000D07 RID: 3335
		private static readonly IntPtr NativeMethodInfoPtr_FindObjectOfType_Public_Static_T_0;

		// Token: 0x04000D08 RID: 3336
		private static readonly IntPtr NativeMethodInfoPtr_CheckNullArgument_Private_Static_Void_Object_String_0;

		// Token: 0x04000D09 RID: 3337
		private static readonly IntPtr NativeMethodInfoPtr_FindObjectOfType_Public_Static_Object_Type_0;

		// Token: 0x04000D0A RID: 3338
		private static readonly IntPtr NativeMethodInfoPtr_FindObjectOfType_Public_Static_Object_Type_Boolean_0;

		// Token: 0x04000D0B RID: 3339
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04000D0C RID: 3340
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Object_Object_0;

		// Token: 0x04000D0D RID: 3341
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Object_Object_0;

		// Token: 0x04000D0E RID: 3342
		private static readonly IntPtr NativeMethodInfoPtr_GetOffsetOfInstanceIDInCPlusPlusObject_Private_Static_Int32_0;

		// Token: 0x04000D0F RID: 3343
		private static readonly IntPtr NativeMethodInfoPtr_Internal_CloneSingle_Private_Static_Object_Object_0;

		// Token: 0x04000D10 RID: 3344
		private static readonly IntPtr NativeMethodInfoPtr_Internal_CloneSingleWithParent_Private_Static_Object_Object_Transform_Boolean_0;

		// Token: 0x04000D11 RID: 3345
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Private_Static_String_Object_0;

		// Token: 0x04000D12 RID: 3346
		private static readonly IntPtr NativeMethodInfoPtr_GetName_Private_Static_String_Object_0;

		// Token: 0x04000D13 RID: 3347
		private static readonly IntPtr NativeMethodInfoPtr_SetName_Private_Static_Void_Object_String_0;

		// Token: 0x04000D14 RID: 3348
		private static readonly IntPtr NativeMethodInfoPtr_FindObjectFromInstanceID_Internal_Static_Object_Int32_0;

		// Token: 0x04000D15 RID: 3349
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000D16 RID: 3350
		private static readonly Object.FindObjectsOfTypeIncludingAssetsDelegate FindObjectsOfTypeIncludingAssetsDelegateField;

		// Token: 0x04000D17 RID: 3351
		private static readonly Object.CurrentThreadIsMainThreadDelegate CurrentThreadIsMainThreadDelegateField;

		// Token: 0x04000D18 RID: 3352
		private static readonly Object.IsPersistentDelegate IsPersistentDelegateField;

		// Token: 0x04000D19 RID: 3353
		private static readonly Object.DoesObjectWithInstanceIDExistDelegate DoesObjectWithInstanceIDExistDelegateField;

		// Token: 0x04000D1A RID: 3354
		private static readonly Object.ForceLoadFromInstanceIDDelegate ForceLoadFromInstanceIDDelegateField;

		// Token: 0x04000D1B RID: 3355
		private static readonly Object.Internal_InstantiateSingle_InjectedDelegate Internal_InstantiateSingle_InjectedDelegateField;

		// Token: 0x04000D1C RID: 3356
		private static readonly Object.Internal_InstantiateSingleWithParent_InjectedDelegate Internal_InstantiateSingleWithParent_InjectedDelegateField;

		// Token: 0x020007AE RID: 1966
		private sealed class MethodInfoStoreGeneric_Instantiate_Public_Static_T_T_0<T>
		{
			// Token: 0x04001CA9 RID: 7337
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Object.NativeMethodInfoPtr_Instantiate_Public_Static_T_T_0, Il2CppClassPointerStore<Object>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020007AF RID: 1967
		private sealed class MethodInfoStoreGeneric_Instantiate_Public_Static_T_T_Transform_Boolean_0<T>
		{
			// Token: 0x04001CAA RID: 7338
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Object.NativeMethodInfoPtr_Instantiate_Public_Static_T_T_Transform_Boolean_0, Il2CppClassPointerStore<Object>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020007B0 RID: 1968
		private sealed class MethodInfoStoreGeneric_FindObjectOfType_Public_Static_T_0<T>
		{
			// Token: 0x04001CAB RID: 7339
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Object.NativeMethodInfoPtr_FindObjectOfType_Public_Static_T_0, Il2CppClassPointerStore<Object>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020007B1 RID: 1969
		// (Invoke) Token: 0x06002D05 RID: 11525
		private delegate IntPtr FindObjectsOfTypeIncludingAssetsDelegate(IntPtr type);

		// Token: 0x020007B2 RID: 1970
		// (Invoke) Token: 0x06002D07 RID: 11527
		private delegate bool CurrentThreadIsMainThreadDelegate();

		// Token: 0x020007B3 RID: 1971
		// (Invoke) Token: 0x06002D09 RID: 11529
		private delegate bool IsPersistentDelegate(IntPtr obj);

		// Token: 0x020007B4 RID: 1972
		// (Invoke) Token: 0x06002D0B RID: 11531
		private delegate bool DoesObjectWithInstanceIDExistDelegate(int instanceID);

		// Token: 0x020007B5 RID: 1973
		// (Invoke) Token: 0x06002D0D RID: 11533
		private delegate IntPtr ForceLoadFromInstanceIDDelegate(int instanceID);

		// Token: 0x020007B6 RID: 1974
		// (Invoke) Token: 0x06002D0F RID: 11535
		private delegate IntPtr Internal_InstantiateSingle_InjectedDelegate(IntPtr data, IntPtr pos, IntPtr rot);

		// Token: 0x020007B7 RID: 1975
		// (Invoke) Token: 0x06002D11 RID: 11537
		private delegate IntPtr Internal_InstantiateSingleWithParent_InjectedDelegate(IntPtr data, IntPtr parent, IntPtr pos, IntPtr rot);
	}
}
