using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Reflection;

namespace UnityEngine
{
	// Token: 0x0200000C RID: 12
	public static class AndroidJNIHelper : Object
	{
		// Token: 0x0600009B RID: 155 RVA: 0x00005808 File Offset: 0x00003A08
		// Note: this type is marked as 'beforefieldinit'.
		static AndroidJNIHelper()
		{
			Il2CppClassPointerStore<AndroidJNIHelper>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.AndroidJNIModule.dll", "UnityEngine", "AndroidJNIHelper");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AndroidJNIHelper>.NativeClassPtr);
			AndroidJNIHelper.NativeMethodInfoPtr_GetConstructorID_Public_Static_IntPtr_IntPtr_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNIHelper>.NativeClassPtr, 100663373);
			AndroidJNIHelper.NativeMethodInfoPtr_GetMethodID_Public_Static_IntPtr_IntPtr_String_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNIHelper>.NativeClassPtr, 100663374);
			AndroidJNIHelper.NativeMethodInfoPtr_GetFieldID_Public_Static_IntPtr_IntPtr_String_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNIHelper>.NativeClassPtr, 100663375);
			AndroidJNIHelper.NativeMethodInfoPtr_CreateJavaRunnable_Public_Static_IntPtr_AndroidJavaRunnable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNIHelper>.NativeClassPtr, 100663376);
			AndroidJNIHelper.NativeMethodInfoPtr_CreateJavaProxy_Public_Static_IntPtr_AndroidJavaProxy_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNIHelper>.NativeClassPtr, 100663377);
			AndroidJNIHelper.NativeMethodInfoPtr_CreateJNIArgArray_Public_Static_Il2CppStructArray_1_jvalue_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNIHelper>.NativeClassPtr, 100663378);
			AndroidJNIHelper.NativeMethodInfoPtr_DeleteJNIArgArray_Public_Static_Void_Il2CppReferenceArray_1_Object_Il2CppStructArray_1_jvalue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNIHelper>.NativeClassPtr, 100663379);
			AndroidJNIHelper.NativeMethodInfoPtr_GetConstructorID_Public_Static_IntPtr_IntPtr_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNIHelper>.NativeClassPtr, 100663380);
			AndroidJNIHelper.NativeMethodInfoPtr_GetMethodID_Public_Static_IntPtr_IntPtr_String_Il2CppReferenceArray_1_Object_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNIHelper>.NativeClassPtr, 100663381);
			AndroidJNIHelper.NativeMethodInfoPtr_ConvertFromJNIArray_Public_Static_ArrayType_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNIHelper>.NativeClassPtr, 100663382);
			AndroidJNIHelper.NativeMethodInfoPtr_GetMethodID_Public_Static_IntPtr_IntPtr_String_Il2CppReferenceArray_1_Object_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNIHelper>.NativeClassPtr, 100663383);
			AndroidJNIHelper.NativeMethodInfoPtr_GetFieldID_Public_Static_IntPtr_IntPtr_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNIHelper>.NativeClassPtr, 100663384);
			AndroidJNIHelper.get_debugDelegateField = IL2CPP.ResolveICall<AndroidJNIHelper.get_debugDelegate>("UnityEngine.AndroidJNIHelper::get_debug");
			AndroidJNIHelper.set_debugDelegateField = IL2CPP.ResolveICall<AndroidJNIHelper.set_debugDelegate>("UnityEngine.AndroidJNIHelper::set_debug");
		}

		// Token: 0x0600009C RID: 156 RVA: 0x00005948 File Offset: 0x00003B48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129714, XrefRangeEnd = 129715, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr GetConstructorID(IntPtr javaClass, string signature)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref javaClass;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(signature);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNIHelper.NativeMethodInfoPtr_GetConstructorID_Public_Static_IntPtr_IntPtr_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600009D RID: 157 RVA: 0x00005998 File Offset: 0x00003B98
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 129716, RefRangeEnd = 129717, XrefRangeStart = 129715, XrefRangeEnd = 129716, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr GetMethodID(IntPtr javaClass, string methodName, string signature, bool isStatic)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref javaClass;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(methodName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(signature);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isStatic;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNIHelper.NativeMethodInfoPtr_GetMethodID_Public_Static_IntPtr_IntPtr_String_String_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600009E RID: 158 RVA: 0x00005A08 File Offset: 0x00003C08
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 129718, RefRangeEnd = 129719, XrefRangeStart = 129717, XrefRangeEnd = 129718, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr GetFieldID(IntPtr javaClass, string fieldName, string signature, bool isStatic)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref javaClass;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(fieldName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(signature);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isStatic;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNIHelper.NativeMethodInfoPtr_GetFieldID_Public_Static_IntPtr_IntPtr_String_String_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600009F RID: 159 RVA: 0x00005A78 File Offset: 0x00003C78
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 128534, RefRangeEnd = 128535, XrefRangeStart = 128534, XrefRangeEnd = 128535, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr CreateJavaRunnable(AndroidJavaRunnable jrunnable)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(jrunnable);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNIHelper.NativeMethodInfoPtr_CreateJavaRunnable_Public_Static_IntPtr_AndroidJavaRunnable_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000A0 RID: 160 RVA: 0x00005ABC File Offset: 0x00003CBC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 129733, RefRangeEnd = 129736, XrefRangeStart = 129719, XrefRangeEnd = 129733, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr CreateJavaProxy(AndroidJavaProxy proxy)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(proxy);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNIHelper.NativeMethodInfoPtr_CreateJavaProxy_Public_Static_IntPtr_AndroidJavaProxy_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x00005B00 File Offset: 0x00003D00
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 129737, RefRangeEnd = 129739, XrefRangeStart = 129736, XrefRangeEnd = 129737, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<jvalue> CreateJNIArgArray(Il2CppReferenceArray<Object> args)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNIHelper.NativeMethodInfoPtr_CreateJNIArgArray_Public_Static_Il2CppStructArray_1_jvalue_Il2CppReferenceArray_1_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<jvalue>>(intPtr3) : null;
			}
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x00005B44 File Offset: 0x00003D44
		[CallerCount(34)]
		[CachedScanResults(RefRangeStart = 128973, RefRangeEnd = 129007, XrefRangeStart = 128973, XrefRangeEnd = 129007, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNIHelper.NativeMethodInfoPtr_DeleteJNIArgArray_Public_Static_Void_Il2CppReferenceArray_1_Object_Il2CppStructArray_1_jvalue_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x00005B8C File Offset: 0x00003D8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNIHelper.NativeMethodInfoPtr_GetConstructorID_Public_Static_IntPtr_IntPtr_Il2CppReferenceArray_1_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000A4 RID: 164 RVA: 0x00005BDC File Offset: 0x00003DDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNIHelper.NativeMethodInfoPtr_GetMethodID_Public_Static_IntPtr_IntPtr_String_Il2CppReferenceArray_1_Object_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x00005C4C File Offset: 0x00003E4C
		[CallerCount(0)]
		public unsafe static ArrayType ConvertFromJNIArray<ArrayType>(IntPtr array)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref array;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNIHelper.MethodInfoStoreGeneric_ConvertFromJNIArray_Public_Static_ArrayType_IntPtr_0<ArrayType>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<ArrayType>(intPtr, false, true);
			}
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x00005C88 File Offset: 0x00003E88
		[CallerCount(0)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNIHelper.MethodInfoStoreGeneric_GetMethodID_Public_Static_IntPtr_IntPtr_String_Il2CppReferenceArray_1_Object_Boolean_0<ReturnType>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x00005CF8 File Offset: 0x00003EF8
		[CallerCount(0)]
		public unsafe static IntPtr GetFieldID<FieldType>(IntPtr jclass, string fieldName, bool isStatic)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNIHelper.MethodInfoStoreGeneric_GetFieldID_Public_Static_IntPtr_IntPtr_String_Boolean_0<FieldType>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x00002355 File Offset: 0x00000555
		public AndroidJNIHelper(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x060000A9 RID: 169 RVA: 0x0000235E File Offset: 0x0000055E
		// (set) Token: 0x060000AA RID: 170 RVA: 0x0000236A File Offset: 0x0000056A
		public static bool debug
		{
			get
			{
				return AndroidJNIHelper.get_debugDelegateField();
			}
			set
			{
				AndroidJNIHelper.set_debugDelegateField(value);
			}
		}

		// Token: 0x060000AB RID: 171 RVA: 0x00005D58 File Offset: 0x00003F58
		public static IntPtr GetConstructorID(IntPtr javaClass)
		{
			return AndroidJNIHelper.GetConstructorID(javaClass, "");
		}

		// Token: 0x060000AC RID: 172 RVA: 0x00005D78 File Offset: 0x00003F78
		public static IntPtr GetMethodID(IntPtr javaClass, string methodName)
		{
			return AndroidJNIHelper.GetMethodID(javaClass, methodName, "", false);
		}

		// Token: 0x060000AD RID: 173 RVA: 0x00005D98 File Offset: 0x00003F98
		public static IntPtr GetMethodID(IntPtr javaClass, string methodName, string signature)
		{
			return AndroidJNIHelper.GetMethodID(javaClass, methodName, signature, false);
		}

		// Token: 0x060000AE RID: 174 RVA: 0x00005DB4 File Offset: 0x00003FB4
		public static IntPtr GetFieldID(IntPtr javaClass, string fieldName)
		{
			return AndroidJNIHelper.GetFieldID(javaClass, fieldName, "", false);
		}

		// Token: 0x060000AF RID: 175 RVA: 0x00005DD4 File Offset: 0x00003FD4
		public static IntPtr GetFieldID(IntPtr javaClass, string fieldName, string signature)
		{
			return AndroidJNIHelper.GetFieldID(javaClass, fieldName, signature, false);
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x00005DF0 File Offset: 0x00003FF0
		public static IntPtr ConvertToJNIArray(Array array)
		{
			return _AndroidJNIHelper.ConvertToJNIArray(array);
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x00005E08 File Offset: 0x00004008
		public static string GetSignature(Object obj)
		{
			return _AndroidJNIHelper.GetSignature(obj);
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x00005E20 File Offset: 0x00004020
		public static string GetSignature(Il2CppReferenceArray<Object> args)
		{
			return _AndroidJNIHelper.GetSignature(args);
		}

		// Token: 0x060000B3 RID: 179 RVA: 0x00005E38 File Offset: 0x00004038
		public static string GetSignature<ReturnType>(Il2CppReferenceArray<Object> args)
		{
			return _AndroidJNIHelper.GetSignature<ReturnType>(args);
		}

		// Token: 0x0400006D RID: 109
		private static readonly IntPtr NativeMethodInfoPtr_GetConstructorID_Public_Static_IntPtr_IntPtr_String_0;

		// Token: 0x0400006E RID: 110
		private static readonly IntPtr NativeMethodInfoPtr_GetMethodID_Public_Static_IntPtr_IntPtr_String_String_Boolean_0;

		// Token: 0x0400006F RID: 111
		private static readonly IntPtr NativeMethodInfoPtr_GetFieldID_Public_Static_IntPtr_IntPtr_String_String_Boolean_0;

		// Token: 0x04000070 RID: 112
		private static readonly IntPtr NativeMethodInfoPtr_CreateJavaRunnable_Public_Static_IntPtr_AndroidJavaRunnable_0;

		// Token: 0x04000071 RID: 113
		private static readonly IntPtr NativeMethodInfoPtr_CreateJavaProxy_Public_Static_IntPtr_AndroidJavaProxy_0;

		// Token: 0x04000072 RID: 114
		private static readonly IntPtr NativeMethodInfoPtr_CreateJNIArgArray_Public_Static_Il2CppStructArray_1_jvalue_Il2CppReferenceArray_1_Object_0;

		// Token: 0x04000073 RID: 115
		private static readonly IntPtr NativeMethodInfoPtr_DeleteJNIArgArray_Public_Static_Void_Il2CppReferenceArray_1_Object_Il2CppStructArray_1_jvalue_0;

		// Token: 0x04000074 RID: 116
		private static readonly IntPtr NativeMethodInfoPtr_GetConstructorID_Public_Static_IntPtr_IntPtr_Il2CppReferenceArray_1_Object_0;

		// Token: 0x04000075 RID: 117
		private static readonly IntPtr NativeMethodInfoPtr_GetMethodID_Public_Static_IntPtr_IntPtr_String_Il2CppReferenceArray_1_Object_Boolean_0;

		// Token: 0x04000076 RID: 118
		private static readonly IntPtr NativeMethodInfoPtr_ConvertFromJNIArray_Public_Static_ArrayType_IntPtr_0;

		// Token: 0x04000077 RID: 119
		private static readonly IntPtr NativeMethodInfoPtr_GetMethodID_Public_Static_IntPtr_IntPtr_String_Il2CppReferenceArray_1_Object_Boolean_0;

		// Token: 0x04000078 RID: 120
		private static readonly IntPtr NativeMethodInfoPtr_GetFieldID_Public_Static_IntPtr_IntPtr_String_Boolean_0;

		// Token: 0x04000079 RID: 121
		private static readonly AndroidJNIHelper.get_debugDelegate get_debugDelegateField;

		// Token: 0x0400007A RID: 122
		private static readonly AndroidJNIHelper.set_debugDelegate set_debugDelegateField;

		// Token: 0x02000025 RID: 37
		private sealed class MethodInfoStoreGeneric_ConvertFromJNIArray_Public_Static_ArrayType_IntPtr_0<ArrayType>
		{
			// Token: 0x0400017F RID: 383
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(AndroidJNIHelper.NativeMethodInfoPtr_ConvertFromJNIArray_Public_Static_ArrayType_IntPtr_0, Il2CppClassPointerStore<AndroidJNIHelper>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<ArrayType>.NativeClassPtr)) }))));
		}

		// Token: 0x02000026 RID: 38
		private sealed class MethodInfoStoreGeneric_GetMethodID_Public_Static_IntPtr_IntPtr_String_Il2CppReferenceArray_1_Object_Boolean_0<ReturnType>
		{
			// Token: 0x04000180 RID: 384
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(AndroidJNIHelper.NativeMethodInfoPtr_GetMethodID_Public_Static_IntPtr_IntPtr_String_Il2CppReferenceArray_1_Object_Boolean_0, Il2CppClassPointerStore<AndroidJNIHelper>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<ReturnType>.NativeClassPtr)) }))));
		}

		// Token: 0x02000027 RID: 39
		private sealed class MethodInfoStoreGeneric_GetFieldID_Public_Static_IntPtr_IntPtr_String_Boolean_0<FieldType>
		{
			// Token: 0x04000181 RID: 385
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(AndroidJNIHelper.NativeMethodInfoPtr_GetFieldID_Public_Static_IntPtr_IntPtr_String_Boolean_0, Il2CppClassPointerStore<AndroidJNIHelper>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<FieldType>.NativeClassPtr)) }))));
		}

		// Token: 0x02000028 RID: 40
		// (Invoke) Token: 0x06000209 RID: 521
		private delegate bool get_debugDelegate();

		// Token: 0x02000029 RID: 41
		// (Invoke) Token: 0x0600020B RID: 523
		private delegate void set_debugDelegate(bool value);
	}
}
