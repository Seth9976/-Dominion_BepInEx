using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Reflection;

namespace UnityEngine
{
	// Token: 0x0200000A RID: 10
	public sealed class _AndroidJNIHelper : Object
	{
		// Token: 0x06000082 RID: 130 RVA: 0x00004EA0 File Offset: 0x000030A0
		// Note: this type is marked as 'beforefieldinit'.
		static _AndroidJNIHelper()
		{
			Il2CppClassPointerStore<_AndroidJNIHelper>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.AndroidJNIModule.dll", "UnityEngine", "_AndroidJNIHelper");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<_AndroidJNIHelper>.NativeClassPtr);
			_AndroidJNIHelper.NativeMethodInfoPtr_CreateJavaProxy_Public_Static_IntPtr_IntPtr_AndroidJavaProxy_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_AndroidJNIHelper>.NativeClassPtr, 100663352);
			_AndroidJNIHelper.NativeMethodInfoPtr_CreateJavaRunnable_Public_Static_IntPtr_AndroidJavaRunnable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_AndroidJNIHelper>.NativeClassPtr, 100663353);
			_AndroidJNIHelper.NativeMethodInfoPtr_InvokeJavaProxyMethod_Public_Static_IntPtr_AndroidJavaProxy_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_AndroidJNIHelper>.NativeClassPtr, 100663354);
			_AndroidJNIHelper.NativeMethodInfoPtr_CreateJNIArgArray_Public_Static_Il2CppStructArray_1_jvalue_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_AndroidJNIHelper>.NativeClassPtr, 100663355);
			_AndroidJNIHelper.NativeMethodInfoPtr_UnboxArray_Public_Static_Object_AndroidJavaObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_AndroidJNIHelper>.NativeClassPtr, 100663356);
			_AndroidJNIHelper.NativeMethodInfoPtr_Unbox_Public_Static_Object_AndroidJavaObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_AndroidJNIHelper>.NativeClassPtr, 100663357);
			_AndroidJNIHelper.NativeMethodInfoPtr_Box_Public_Static_AndroidJavaObject_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_AndroidJNIHelper>.NativeClassPtr, 100663358);
			_AndroidJNIHelper.NativeMethodInfoPtr_DeleteJNIArgArray_Public_Static_Void_Il2CppReferenceArray_1_Object_Il2CppStructArray_1_jvalue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_AndroidJNIHelper>.NativeClassPtr, 100663359);
			_AndroidJNIHelper.NativeMethodInfoPtr_ConvertToJNIArray_Public_Static_IntPtr_Array_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_AndroidJNIHelper>.NativeClassPtr, 100663360);
			_AndroidJNIHelper.NativeMethodInfoPtr_ConvertFromJNIArray_Public_Static_ArrayType_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_AndroidJNIHelper>.NativeClassPtr, 100663361);
			_AndroidJNIHelper.NativeMethodInfoPtr_GetConstructorID_Public_Static_IntPtr_IntPtr_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_AndroidJNIHelper>.NativeClassPtr, 100663362);
			_AndroidJNIHelper.NativeMethodInfoPtr_GetMethodID_Public_Static_IntPtr_IntPtr_String_Il2CppReferenceArray_1_Object_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_AndroidJNIHelper>.NativeClassPtr, 100663363);
			_AndroidJNIHelper.NativeMethodInfoPtr_GetMethodID_Public_Static_IntPtr_IntPtr_String_Il2CppReferenceArray_1_Object_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_AndroidJNIHelper>.NativeClassPtr, 100663364);
			_AndroidJNIHelper.NativeMethodInfoPtr_GetFieldID_Public_Static_IntPtr_IntPtr_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_AndroidJNIHelper>.NativeClassPtr, 100663365);
			_AndroidJNIHelper.NativeMethodInfoPtr_GetConstructorID_Public_Static_IntPtr_IntPtr_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_AndroidJNIHelper>.NativeClassPtr, 100663366);
			_AndroidJNIHelper.NativeMethodInfoPtr_GetMethodID_Public_Static_IntPtr_IntPtr_String_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_AndroidJNIHelper>.NativeClassPtr, 100663367);
			_AndroidJNIHelper.NativeMethodInfoPtr_GetMethodIDFallback_Private_Static_IntPtr_IntPtr_String_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_AndroidJNIHelper>.NativeClassPtr, 100663368);
			_AndroidJNIHelper.NativeMethodInfoPtr_GetFieldID_Public_Static_IntPtr_IntPtr_String_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_AndroidJNIHelper>.NativeClassPtr, 100663369);
			_AndroidJNIHelper.NativeMethodInfoPtr_GetSignature_Public_Static_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_AndroidJNIHelper>.NativeClassPtr, 100663370);
			_AndroidJNIHelper.NativeMethodInfoPtr_GetSignature_Public_Static_String_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_AndroidJNIHelper>.NativeClassPtr, 100663371);
			_AndroidJNIHelper.NativeMethodInfoPtr_GetSignature_Public_Static_String_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_AndroidJNIHelper>.NativeClassPtr, 100663372);
		}

		// Token: 0x06000083 RID: 131 RVA: 0x00005074 File Offset: 0x00003274
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128507, XrefRangeEnd = 128519, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr CreateJavaProxy(IntPtr delegateHandle, AndroidJavaProxy proxy)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref delegateHandle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(proxy);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(_AndroidJNIHelper.NativeMethodInfoPtr_CreateJavaProxy_Public_Static_IntPtr_IntPtr_AndroidJavaProxy_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000084 RID: 132 RVA: 0x000050C4 File Offset: 0x000032C4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 128534, RefRangeEnd = 128535, XrefRangeStart = 128519, XrefRangeEnd = 128534, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr CreateJavaRunnable(AndroidJavaRunnable jrunnable)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(jrunnable);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(_AndroidJNIHelper.NativeMethodInfoPtr_CreateJavaRunnable_Public_Static_IntPtr_AndroidJavaRunnable_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000085 RID: 133 RVA: 0x00005108 File Offset: 0x00003308
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128535, XrefRangeEnd = 128567, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr InvokeJavaProxyMethod(AndroidJavaProxy proxy, IntPtr jmethodName, IntPtr jargs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(proxy);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref jmethodName;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref jargs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(_AndroidJNIHelper.NativeMethodInfoPtr_InvokeJavaProxyMethod_Public_Static_IntPtr_AndroidJavaProxy_IntPtr_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000086 RID: 134 RVA: 0x00005168 File Offset: 0x00003368
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 128642, RefRangeEnd = 128645, XrefRangeStart = 128567, XrefRangeEnd = 128642, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<jvalue> CreateJNIArgArray(Il2CppReferenceArray<Object> args)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(_AndroidJNIHelper.NativeMethodInfoPtr_CreateJNIArgArray_Public_Static_Il2CppStructArray_1_jvalue_Il2CppReferenceArray_1_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<jvalue>>(intPtr3) : null;
			}
		}

		// Token: 0x06000087 RID: 135 RVA: 0x000051AC File Offset: 0x000033AC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 128769, RefRangeEnd = 128770, XrefRangeStart = 128645, XrefRangeEnd = 128769, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object UnboxArray(AndroidJavaObject obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(_AndroidJNIHelper.NativeMethodInfoPtr_UnboxArray_Public_Static_Object_AndroidJavaObject_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06000088 RID: 136 RVA: 0x000051F0 File Offset: 0x000033F0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 128928, RefRangeEnd = 128930, XrefRangeStart = 128770, XrefRangeEnd = 128928, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object Unbox(AndroidJavaObject obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(_AndroidJNIHelper.NativeMethodInfoPtr_Unbox_Public_Static_Object_AndroidJavaObject_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06000089 RID: 137 RVA: 0x00005234 File Offset: 0x00003434
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 128964, RefRangeEnd = 128965, XrefRangeStart = 128930, XrefRangeEnd = 128964, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AndroidJavaObject Box(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(_AndroidJNIHelper.NativeMethodInfoPtr_Box_Public_Static_AndroidJavaObject_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AndroidJavaObject>(intPtr3) : null;
			}
		}

		// Token: 0x0600008A RID: 138 RVA: 0x00005278 File Offset: 0x00003478
		[CallerCount(34)]
		[CachedScanResults(RefRangeStart = 128973, RefRangeEnd = 129007, XrefRangeStart = 128965, XrefRangeEnd = 128973, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DeleteJNIArgArray(Il2CppReferenceArray<Object> args, Il2CppStructArray<jvalue> jniArgs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(jniArgs);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(_AndroidJNIHelper.NativeMethodInfoPtr_DeleteJNIArgArray_Public_Static_Void_Il2CppReferenceArray_1_Object_Il2CppStructArray_1_jvalue_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600008B RID: 139 RVA: 0x000052C0 File Offset: 0x000034C0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 129159, RefRangeEnd = 129160, XrefRangeStart = 129007, XrefRangeEnd = 129159, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr ConvertToJNIArray(Array array)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(_AndroidJNIHelper.NativeMethodInfoPtr_ConvertToJNIArray_Public_Static_IntPtr_Array_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600008C RID: 140 RVA: 0x00005304 File Offset: 0x00003504
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129160, XrefRangeEnd = 129247, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ArrayType ConvertFromJNIArray<ArrayType>(IntPtr array)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref array;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(_AndroidJNIHelper.MethodInfoStoreGeneric_ConvertFromJNIArray_Public_Static_ArrayType_IntPtr_0<ArrayType>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<ArrayType>(intPtr, false, true);
			}
		}

		// Token: 0x0600008D RID: 141 RVA: 0x00005340 File Offset: 0x00003540
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129247, XrefRangeEnd = 129249, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr GetConstructorID(IntPtr jclass, Il2CppReferenceArray<Object> args)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref jclass;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(_AndroidJNIHelper.NativeMethodInfoPtr_GetConstructorID_Public_Static_IntPtr_IntPtr_Il2CppReferenceArray_1_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600008E RID: 142 RVA: 0x00005390 File Offset: 0x00003590
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129249, XrefRangeEnd = 129251, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr GetMethodID(IntPtr jclass, string methodName, Il2CppReferenceArray<Object> args, bool isStatic)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref jclass;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(methodName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isStatic;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(_AndroidJNIHelper.NativeMethodInfoPtr_GetMethodID_Public_Static_IntPtr_IntPtr_String_Il2CppReferenceArray_1_Object_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600008F RID: 143 RVA: 0x00005400 File Offset: 0x00003600
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129251, XrefRangeEnd = 129252, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr GetMethodID<ReturnType>(IntPtr jclass, string methodName, Il2CppReferenceArray<Object> args, bool isStatic)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref jclass;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(methodName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isStatic;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(_AndroidJNIHelper.MethodInfoStoreGeneric_GetMethodID_Public_Static_IntPtr_IntPtr_String_Il2CppReferenceArray_1_Object_Boolean_0<ReturnType>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000090 RID: 144 RVA: 0x00005470 File Offset: 0x00003670
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129252, XrefRangeEnd = 129258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr GetFieldID<ReturnType>(IntPtr jclass, string fieldName, bool isStatic)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref jclass;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(fieldName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isStatic;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(_AndroidJNIHelper.MethodInfoStoreGeneric_GetFieldID_Public_Static_IntPtr_IntPtr_String_Boolean_0<ReturnType>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000091 RID: 145 RVA: 0x000054D0 File Offset: 0x000036D0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 129273, RefRangeEnd = 129277, XrefRangeStart = 129258, XrefRangeEnd = 129273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr GetConstructorID(IntPtr jclass, string signature)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref jclass;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(signature);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(_AndroidJNIHelper.NativeMethodInfoPtr_GetConstructorID_Public_Static_IntPtr_IntPtr_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000092 RID: 146 RVA: 0x00005520 File Offset: 0x00003720
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 129291, RefRangeEnd = 129296, XrefRangeStart = 129277, XrefRangeEnd = 129291, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr GetMethodID(IntPtr jclass, string methodName, string signature, bool isStatic)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref jclass;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(methodName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(signature);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isStatic;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(_AndroidJNIHelper.NativeMethodInfoPtr_GetMethodID_Public_Static_IntPtr_IntPtr_String_String_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000093 RID: 147 RVA: 0x00005590 File Offset: 0x00003790
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 129301, RefRangeEnd = 129302, XrefRangeStart = 129296, XrefRangeEnd = 129301, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr GetMethodIDFallback(IntPtr jclass, string methodName, string signature, bool isStatic)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref jclass;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(methodName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(signature);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isStatic;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(_AndroidJNIHelper.NativeMethodInfoPtr_GetMethodIDFallback_Private_Static_IntPtr_IntPtr_String_String_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000094 RID: 148 RVA: 0x00005600 File Offset: 0x00003800
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 129336, RefRangeEnd = 129337, XrefRangeStart = 129302, XrefRangeEnd = 129336, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr GetFieldID(IntPtr jclass, string fieldName, string signature, bool isStatic)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref jclass;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(fieldName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(signature);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isStatic;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(_AndroidJNIHelper.NativeMethodInfoPtr_GetFieldID_Public_Static_IntPtr_IntPtr_String_String_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000095 RID: 149 RVA: 0x00005670 File Offset: 0x00003870
		[CallerCount(21)]
		[CachedScanResults(RefRangeStart = 129511, RefRangeEnd = 129532, XrefRangeStart = 129337, XrefRangeEnd = 129511, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetSignature(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(_AndroidJNIHelper.NativeMethodInfoPtr_GetSignature_Public_Static_String_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000096 RID: 150 RVA: 0x000056AC File Offset: 0x000038AC
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 129546, RefRangeEnd = 129552, XrefRangeStart = 129532, XrefRangeEnd = 129546, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetSignature(Il2CppReferenceArray<Object> args)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(_AndroidJNIHelper.NativeMethodInfoPtr_GetSignature_Public_Static_String_Il2CppReferenceArray_1_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000097 RID: 151 RVA: 0x000056E8 File Offset: 0x000038E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129552, XrefRangeEnd = 129714, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetSignature<ReturnType>(Il2CppReferenceArray<Object> args)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(_AndroidJNIHelper.MethodInfoStoreGeneric_GetSignature_Public_Static_String_Il2CppReferenceArray_1_Object_0<ReturnType>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000098 RID: 152 RVA: 0x0000233A File Offset: 0x0000053A
		public _AndroidJNIHelper(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000046 RID: 70
		private static readonly IntPtr NativeMethodInfoPtr_CreateJavaProxy_Public_Static_IntPtr_IntPtr_AndroidJavaProxy_0;

		// Token: 0x04000047 RID: 71
		private static readonly IntPtr NativeMethodInfoPtr_CreateJavaRunnable_Public_Static_IntPtr_AndroidJavaRunnable_0;

		// Token: 0x04000048 RID: 72
		private static readonly IntPtr NativeMethodInfoPtr_InvokeJavaProxyMethod_Public_Static_IntPtr_AndroidJavaProxy_IntPtr_IntPtr_0;

		// Token: 0x04000049 RID: 73
		private static readonly IntPtr NativeMethodInfoPtr_CreateJNIArgArray_Public_Static_Il2CppStructArray_1_jvalue_Il2CppReferenceArray_1_Object_0;

		// Token: 0x0400004A RID: 74
		private static readonly IntPtr NativeMethodInfoPtr_UnboxArray_Public_Static_Object_AndroidJavaObject_0;

		// Token: 0x0400004B RID: 75
		private static readonly IntPtr NativeMethodInfoPtr_Unbox_Public_Static_Object_AndroidJavaObject_0;

		// Token: 0x0400004C RID: 76
		private static readonly IntPtr NativeMethodInfoPtr_Box_Public_Static_AndroidJavaObject_Object_0;

		// Token: 0x0400004D RID: 77
		private static readonly IntPtr NativeMethodInfoPtr_DeleteJNIArgArray_Public_Static_Void_Il2CppReferenceArray_1_Object_Il2CppStructArray_1_jvalue_0;

		// Token: 0x0400004E RID: 78
		private static readonly IntPtr NativeMethodInfoPtr_ConvertToJNIArray_Public_Static_IntPtr_Array_0;

		// Token: 0x0400004F RID: 79
		private static readonly IntPtr NativeMethodInfoPtr_ConvertFromJNIArray_Public_Static_ArrayType_IntPtr_0;

		// Token: 0x04000050 RID: 80
		private static readonly IntPtr NativeMethodInfoPtr_GetConstructorID_Public_Static_IntPtr_IntPtr_Il2CppReferenceArray_1_Object_0;

		// Token: 0x04000051 RID: 81
		private static readonly IntPtr NativeMethodInfoPtr_GetMethodID_Public_Static_IntPtr_IntPtr_String_Il2CppReferenceArray_1_Object_Boolean_0;

		// Token: 0x04000052 RID: 82
		private static readonly IntPtr NativeMethodInfoPtr_GetMethodID_Public_Static_IntPtr_IntPtr_String_Il2CppReferenceArray_1_Object_Boolean_0;

		// Token: 0x04000053 RID: 83
		private static readonly IntPtr NativeMethodInfoPtr_GetFieldID_Public_Static_IntPtr_IntPtr_String_Boolean_0;

		// Token: 0x04000054 RID: 84
		private static readonly IntPtr NativeMethodInfoPtr_GetConstructorID_Public_Static_IntPtr_IntPtr_String_0;

		// Token: 0x04000055 RID: 85
		private static readonly IntPtr NativeMethodInfoPtr_GetMethodID_Public_Static_IntPtr_IntPtr_String_String_Boolean_0;

		// Token: 0x04000056 RID: 86
		private static readonly IntPtr NativeMethodInfoPtr_GetMethodIDFallback_Private_Static_IntPtr_IntPtr_String_String_Boolean_0;

		// Token: 0x04000057 RID: 87
		private static readonly IntPtr NativeMethodInfoPtr_GetFieldID_Public_Static_IntPtr_IntPtr_String_String_Boolean_0;

		// Token: 0x04000058 RID: 88
		private static readonly IntPtr NativeMethodInfoPtr_GetSignature_Public_Static_String_Object_0;

		// Token: 0x04000059 RID: 89
		private static readonly IntPtr NativeMethodInfoPtr_GetSignature_Public_Static_String_Il2CppReferenceArray_1_Object_0;

		// Token: 0x0400005A RID: 90
		private static readonly IntPtr NativeMethodInfoPtr_GetSignature_Public_Static_String_Il2CppReferenceArray_1_Object_0;

		// Token: 0x02000021 RID: 33
		private sealed class MethodInfoStoreGeneric_ConvertFromJNIArray_Public_Static_ArrayType_IntPtr_0<ArrayType>
		{
			// Token: 0x0400017B RID: 379
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(_AndroidJNIHelper.NativeMethodInfoPtr_ConvertFromJNIArray_Public_Static_ArrayType_IntPtr_0, Il2CppClassPointerStore<_AndroidJNIHelper>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<ArrayType>.NativeClassPtr)) }))));
		}

		// Token: 0x02000022 RID: 34
		private sealed class MethodInfoStoreGeneric_GetMethodID_Public_Static_IntPtr_IntPtr_String_Il2CppReferenceArray_1_Object_Boolean_0<ReturnType>
		{
			// Token: 0x0400017C RID: 380
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(_AndroidJNIHelper.NativeMethodInfoPtr_GetMethodID_Public_Static_IntPtr_IntPtr_String_Il2CppReferenceArray_1_Object_Boolean_0, Il2CppClassPointerStore<_AndroidJNIHelper>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<ReturnType>.NativeClassPtr)) }))));
		}

		// Token: 0x02000023 RID: 35
		private sealed class MethodInfoStoreGeneric_GetFieldID_Public_Static_IntPtr_IntPtr_String_Boolean_0<ReturnType>
		{
			// Token: 0x0400017D RID: 381
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(_AndroidJNIHelper.NativeMethodInfoPtr_GetFieldID_Public_Static_IntPtr_IntPtr_String_Boolean_0, Il2CppClassPointerStore<_AndroidJNIHelper>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<ReturnType>.NativeClassPtr)) }))));
		}

		// Token: 0x02000024 RID: 36
		private sealed class MethodInfoStoreGeneric_GetSignature_Public_Static_String_Il2CppReferenceArray_1_Object_0<ReturnType>
		{
			// Token: 0x0400017E RID: 382
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(_AndroidJNIHelper.NativeMethodInfoPtr_GetSignature_Public_Static_String_Il2CppReferenceArray_1_Object_0, Il2CppClassPointerStore<_AndroidJNIHelper>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<ReturnType>.NativeClassPtr)) }))));
		}
	}
}
