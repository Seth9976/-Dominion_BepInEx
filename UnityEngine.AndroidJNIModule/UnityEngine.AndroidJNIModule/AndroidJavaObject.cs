using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Reflection;

namespace UnityEngine
{
	// Token: 0x02000007 RID: 7
	public class AndroidJavaObject : Object
	{
		// Token: 0x06000031 RID: 49 RVA: 0x000032A0 File Offset: 0x000014A0
		// Note: this type is marked as 'beforefieldinit'.
		static AndroidJavaObject()
		{
			Il2CppClassPointerStore<AndroidJavaObject>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.AndroidJNIModule.dll", "UnityEngine", "AndroidJavaObject");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AndroidJavaObject>.NativeClassPtr);
			AndroidJavaObject.NativeFieldInfoPtr_enableDebugPrints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidJavaObject>.NativeClassPtr, "enableDebugPrints");
			AndroidJavaObject.NativeFieldInfoPtr_m_jobject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidJavaObject>.NativeClassPtr, "m_jobject");
			AndroidJavaObject.NativeFieldInfoPtr_m_jclass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidJavaObject>.NativeClassPtr, "m_jclass");
			AndroidJavaObject.NativeMethodInfoPtr__ctor_Public_Void_String_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJavaObject>.NativeClassPtr, 100663314);
			AndroidJavaObject.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJavaObject>.NativeClassPtr, 100663315);
			AndroidJavaObject.NativeMethodInfoPtr_Call_Public_Void_String_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJavaObject>.NativeClassPtr, 100663316);
			AndroidJavaObject.NativeMethodInfoPtr_GetStatic_Public_FieldType_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJavaObject>.NativeClassPtr, 100663317);
			AndroidJavaObject.NativeMethodInfoPtr_GetRawObject_Public_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJavaObject>.NativeClassPtr, 100663318);
			AndroidJavaObject.NativeMethodInfoPtr_GetRawClass_Public_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJavaObject>.NativeClassPtr, 100663319);
			AndroidJavaObject.NativeMethodInfoPtr_Call_Public_ReturnType_String_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJavaObject>.NativeClassPtr, 100663320);
			AndroidJavaObject.NativeMethodInfoPtr_CallStatic_Public_ReturnType_String_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJavaObject>.NativeClassPtr, 100663321);
			AndroidJavaObject.NativeMethodInfoPtr_DebugPrint_Protected_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJavaObject>.NativeClassPtr, 100663322);
			AndroidJavaObject.NativeMethodInfoPtr__AndroidJavaObject_Private_Void_String_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJavaObject>.NativeClassPtr, 100663323);
			AndroidJavaObject.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJavaObject>.NativeClassPtr, 100663325);
			AndroidJavaObject.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJavaObject>.NativeClassPtr, 100663326);
			AndroidJavaObject.NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJavaObject>.NativeClassPtr, 100663327);
			AndroidJavaObject.NativeMethodInfoPtr__Call_Protected_Void_String_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJavaObject>.NativeClassPtr, 100663328);
			AndroidJavaObject.NativeMethodInfoPtr__Call_Protected_ReturnType_String_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJavaObject>.NativeClassPtr, 100663329);
			AndroidJavaObject.NativeMethodInfoPtr__CallStatic_Protected_ReturnType_String_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJavaObject>.NativeClassPtr, 100663330);
			AndroidJavaObject.NativeMethodInfoPtr__GetStatic_Protected_FieldType_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJavaObject>.NativeClassPtr, 100663331);
			AndroidJavaObject.NativeMethodInfoPtr_AndroidJavaObjectDeleteLocalRef_Internal_Static_AndroidJavaObject_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJavaObject>.NativeClassPtr, 100663332);
			AndroidJavaObject.NativeMethodInfoPtr_AndroidJavaClassDeleteLocalRef_Internal_Static_AndroidJavaClass_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJavaObject>.NativeClassPtr, 100663333);
			AndroidJavaObject.NativeMethodInfoPtr__GetRawObject_Protected_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJavaObject>.NativeClassPtr, 100663334);
			AndroidJavaObject.NativeMethodInfoPtr__GetRawClass_Protected_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJavaObject>.NativeClassPtr, 100663335);
		}

		// Token: 0x06000032 RID: 50 RVA: 0x000034B0 File Offset: 0x000016B0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 127555, RefRangeEnd = 127556, XrefRangeStart = 127538, XrefRangeEnd = 127555, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AndroidJavaObject(string className, [Optional] Il2CppReferenceArray<Object> args)
		{
			if (args == null)
			{
				args = new Il2CppReferenceArray<Object>(0L);
			}
			this..ctor(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AndroidJavaObject>.NativeClassPtr));
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(className);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJavaObject.NativeMethodInfoPtr__ctor_Public_Void_String_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000033 RID: 51 RVA: 0x0000351C File Offset: 0x0000171C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 127560, RefRangeEnd = 127561, XrefRangeStart = 127556, XrefRangeEnd = 127560, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJavaObject.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000034 RID: 52 RVA: 0x00003550 File Offset: 0x00001750
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 127562, RefRangeEnd = 127569, XrefRangeStart = 127561, XrefRangeEnd = 127562, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Call(string methodName, [Optional] Il2CppReferenceArray<Object> args)
		{
			if (args == null)
			{
				args = new Il2CppReferenceArray<Object>(0L);
			}
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(methodName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJavaObject.NativeMethodInfoPtr_Call_Public_Void_String_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000035 RID: 53 RVA: 0x000035B4 File Offset: 0x000017B4
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 127570, RefRangeEnd = 127580, XrefRangeStart = 127569, XrefRangeEnd = 127570, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FieldType GetStatic<FieldType>(string fieldName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(fieldName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJavaObject.MethodInfoStoreGeneric_GetStatic_Public_FieldType_String_0<FieldType>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<FieldType>(intPtr, false, true);
			}
		}

		// Token: 0x06000036 RID: 54 RVA: 0x00003600 File Offset: 0x00001800
		[CallerCount(0)]
		public unsafe IntPtr GetRawObject()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJavaObject.NativeMethodInfoPtr_GetRawObject_Public_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000037 RID: 55 RVA: 0x0000363C File Offset: 0x0000183C
		[CallerCount(0)]
		public unsafe IntPtr GetRawClass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJavaObject.NativeMethodInfoPtr_GetRawClass_Public_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000038 RID: 56 RVA: 0x00003678 File Offset: 0x00001878
		[CallerCount(81)]
		[CachedScanResults(RefRangeStart = 127581, RefRangeEnd = 127662, XrefRangeStart = 127580, XrefRangeEnd = 127581, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ReturnType Call<ReturnType>(string methodName, [Optional] Il2CppReferenceArray<Object> args)
		{
			if (args == null)
			{
				args = new Il2CppReferenceArray<Object>(0L);
			}
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(methodName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJavaObject.MethodInfoStoreGeneric_Call_Public_ReturnType_String_Il2CppReferenceArray_1_Object_0<ReturnType>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<ReturnType>(intPtr, false, true);
		}

		// Token: 0x06000039 RID: 57 RVA: 0x000036E4 File Offset: 0x000018E4
		[CallerCount(81)]
		[CachedScanResults(RefRangeStart = 127581, RefRangeEnd = 127662, XrefRangeStart = 127581, XrefRangeEnd = 127662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ReturnType CallStatic<ReturnType>(string methodName, [Optional] Il2CppReferenceArray<Object> args)
		{
			if (args == null)
			{
				args = new Il2CppReferenceArray<Object>(0L);
			}
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(methodName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJavaObject.MethodInfoStoreGeneric_CallStatic_Public_ReturnType_String_Il2CppReferenceArray_1_Object_0<ReturnType>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<ReturnType>(intPtr, false, true);
		}

		// Token: 0x0600003A RID: 58 RVA: 0x00003750 File Offset: 0x00001950
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 127670, RefRangeEnd = 127673, XrefRangeStart = 127662, XrefRangeEnd = 127670, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DebugPrint(string msg)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(msg);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJavaObject.NativeMethodInfoPtr_DebugPrint_Protected_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600003B RID: 59 RVA: 0x00003794 File Offset: 0x00001994
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 127704, RefRangeEnd = 127705, XrefRangeStart = 127673, XrefRangeEnd = 127704, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _AndroidJavaObject(string className, [Optional] Il2CppReferenceArray<Object> args)
		{
			if (args == null)
			{
				args = new Il2CppReferenceArray<Object>(0L);
			}
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(className);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJavaObject.NativeMethodInfoPtr__AndroidJavaObject_Private_Void_String_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600003C RID: 60 RVA: 0x000037F8 File Offset: 0x000019F8
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AndroidJavaObject()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AndroidJavaObject>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJavaObject.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600003D RID: 61 RVA: 0x00003834 File Offset: 0x00001A34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 127705, XrefRangeEnd = 127708, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void Finalize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AndroidJavaObject.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600003E RID: 62 RVA: 0x00003870 File Offset: 0x00001A70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 127708, XrefRangeEnd = 127710, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose(bool disposing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref disposing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AndroidJavaObject.NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600003F RID: 63 RVA: 0x000038BC File Offset: 0x00001ABC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 127720, RefRangeEnd = 127721, XrefRangeStart = 127710, XrefRangeEnd = 127720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Call(string methodName, [Optional] Il2CppReferenceArray<Object> args)
		{
			if (args == null)
			{
				args = new Il2CppReferenceArray<Object>(0L);
			}
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(methodName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJavaObject.NativeMethodInfoPtr__Call_Protected_Void_String_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000040 RID: 64 RVA: 0x00003920 File Offset: 0x00001B20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 127721, XrefRangeEnd = 127944, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ReturnType _Call<ReturnType>(string methodName, [Optional] Il2CppReferenceArray<Object> args)
		{
			if (args == null)
			{
				args = new Il2CppReferenceArray<Object>(0L);
			}
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(methodName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJavaObject.MethodInfoStoreGeneric__Call_Protected_ReturnType_String_Il2CppReferenceArray_1_Object_0<ReturnType>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<ReturnType>(intPtr, false, true);
		}

		// Token: 0x06000041 RID: 65 RVA: 0x0000398C File Offset: 0x00001B8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 127944, XrefRangeEnd = 128164, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ReturnType _CallStatic<ReturnType>(string methodName, [Optional] Il2CppReferenceArray<Object> args)
		{
			if (args == null)
			{
				args = new Il2CppReferenceArray<Object>(0L);
			}
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(methodName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJavaObject.MethodInfoStoreGeneric__CallStatic_Protected_ReturnType_String_Il2CppReferenceArray_1_Object_0<ReturnType>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<ReturnType>(intPtr, false, true);
		}

		// Token: 0x06000042 RID: 66 RVA: 0x000039F8 File Offset: 0x00001BF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128164, XrefRangeEnd = 128293, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FieldType _GetStatic<FieldType>(string fieldName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(fieldName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJavaObject.MethodInfoStoreGeneric__GetStatic_Protected_FieldType_String_0<FieldType>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<FieldType>(intPtr, false, true);
			}
		}

		// Token: 0x06000043 RID: 67 RVA: 0x00003A44 File Offset: 0x00001C44
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 128302, RefRangeEnd = 128306, XrefRangeStart = 128293, XrefRangeEnd = 128302, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AndroidJavaObject AndroidJavaObjectDeleteLocalRef(IntPtr jobject)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref jobject;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJavaObject.NativeMethodInfoPtr_AndroidJavaObjectDeleteLocalRef_Internal_Static_AndroidJavaObject_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AndroidJavaObject>(intPtr3) : null;
			}
		}

		// Token: 0x06000044 RID: 68 RVA: 0x00003A84 File Offset: 0x00001C84
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 128315, RefRangeEnd = 128318, XrefRangeStart = 128306, XrefRangeEnd = 128315, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AndroidJavaClass AndroidJavaClassDeleteLocalRef(IntPtr jclass)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref jclass;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJavaObject.NativeMethodInfoPtr_AndroidJavaClassDeleteLocalRef_Internal_Static_AndroidJavaClass_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AndroidJavaClass>(intPtr3) : null;
			}
		}

		// Token: 0x06000045 RID: 69 RVA: 0x00003AC4 File Offset: 0x00001CC4
		[CallerCount(0)]
		public unsafe IntPtr _GetRawObject()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJavaObject.NativeMethodInfoPtr__GetRawObject_Protected_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000046 RID: 70 RVA: 0x00003B00 File Offset: 0x00001D00
		[CallerCount(0)]
		public unsafe IntPtr _GetRawClass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJavaObject.NativeMethodInfoPtr__GetRawClass_Protected_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000047 RID: 71 RVA: 0x0000218E File Offset: 0x0000038E
		public AndroidJavaObject(string className, params Object[] args)
			: this(className, new Il2CppReferenceArray<Object>(args))
		{
		}

		// Token: 0x06000048 RID: 72 RVA: 0x0000219D File Offset: 0x0000039D
		public void Call(string methodName, params Object[] args)
		{
			this.Call(methodName, new Il2CppReferenceArray<Object>(args));
		}

		// Token: 0x06000049 RID: 73 RVA: 0x000021AC File Offset: 0x000003AC
		public ReturnType Call<ReturnType>(string methodName, params Object[] args)
		{
			return this.Call(methodName, new Il2CppReferenceArray<Object>(args));
		}

		// Token: 0x0600004A RID: 74 RVA: 0x000021BB File Offset: 0x000003BB
		public ReturnType CallStatic<ReturnType>(string methodName, params Object[] args)
		{
			return this.CallStatic(methodName, new Il2CppReferenceArray<Object>(args));
		}

		// Token: 0x0600004B RID: 75 RVA: 0x000021CA File Offset: 0x000003CA
		public void _AndroidJavaObject(string className, params Object[] args)
		{
			this._AndroidJavaObject(className, new Il2CppReferenceArray<Object>(args));
		}

		// Token: 0x0600004C RID: 76 RVA: 0x000021D9 File Offset: 0x000003D9
		public void _Call(string methodName, params Object[] args)
		{
			this._Call(methodName, new Il2CppReferenceArray<Object>(args));
		}

		// Token: 0x0600004D RID: 77 RVA: 0x000021E8 File Offset: 0x000003E8
		public ReturnType _Call<ReturnType>(string methodName, params Object[] args)
		{
			return this._Call(methodName, new Il2CppReferenceArray<Object>(args));
		}

		// Token: 0x0600004E RID: 78 RVA: 0x000021F7 File Offset: 0x000003F7
		public ReturnType _CallStatic<ReturnType>(string methodName, params Object[] args)
		{
			return this._CallStatic(methodName, new Il2CppReferenceArray<Object>(args));
		}

		// Token: 0x0600004F RID: 79 RVA: 0x00002206 File Offset: 0x00000406
		public AndroidJavaObject(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000050 RID: 80 RVA: 0x00003B3C File Offset: 0x00001D3C
		// (set) Token: 0x06000051 RID: 81 RVA: 0x0000220F File Offset: 0x0000040F
		public unsafe static bool enableDebugPrints
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(AndroidJavaObject.NativeFieldInfoPtr_enableDebugPrints, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AndroidJavaObject.NativeFieldInfoPtr_enableDebugPrints, (void*)(&value));
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000052 RID: 82 RVA: 0x00003B58 File Offset: 0x00001D58
		// (set) Token: 0x06000053 RID: 83 RVA: 0x0000221D File Offset: 0x0000041D
		public unsafe GlobalJavaObjectRef m_jobject
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidJavaObject.NativeFieldInfoPtr_m_jobject);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GlobalJavaObjectRef>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidJavaObject.NativeFieldInfoPtr_m_jobject), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000054 RID: 84 RVA: 0x00003B88 File Offset: 0x00001D88
		// (set) Token: 0x06000055 RID: 85 RVA: 0x0000223C File Offset: 0x0000043C
		public unsafe GlobalJavaObjectRef m_jclass
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidJavaObject.NativeFieldInfoPtr_m_jclass);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GlobalJavaObjectRef>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidJavaObject.NativeFieldInfoPtr_m_jclass), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x06000056 RID: 86 RVA: 0x0000225B File Offset: 0x0000045B
		public void Call<T>(string methodName, Il2CppArrayBase<T> args)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000057 RID: 87 RVA: 0x00002268 File Offset: 0x00000468
		public void CallStatic<T>(string methodName, Il2CppArrayBase<T> args)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000058 RID: 88 RVA: 0x00003BB8 File Offset: 0x00001DB8
		public FieldType Get<FieldType>(string fieldName)
		{
			return this._Get<FieldType>(fieldName);
		}

		// Token: 0x06000059 RID: 89 RVA: 0x00002275 File Offset: 0x00000475
		public void Set<FieldType>(string fieldName, FieldType val)
		{
			this._Set<FieldType>(fieldName, val);
		}

		// Token: 0x0600005A RID: 90 RVA: 0x00002281 File Offset: 0x00000481
		public void SetStatic<FieldType>(string fieldName, FieldType val)
		{
			this._SetStatic<FieldType>(fieldName, val);
		}

		// Token: 0x0600005B RID: 91 RVA: 0x0000228D File Offset: 0x0000048D
		public ReturnType Call<ReturnType, T>(string methodName, Il2CppArrayBase<T> args)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600005C RID: 92 RVA: 0x0000229A File Offset: 0x0000049A
		public ReturnType CallStatic<ReturnType, T>(string methodName, Il2CppArrayBase<T> args)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600005D RID: 93 RVA: 0x000022A7 File Offset: 0x000004A7
		public void DebugPrint(string call, string methodName, string signature, Il2CppReferenceArray<Object> args)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600005E RID: 94 RVA: 0x00003BD4 File Offset: 0x00001DD4
		public FieldType _Get<FieldType>(string fieldName)
		{
			IntPtr fieldID = AndroidJNIHelper.GetFieldID<FieldType>(this.m_jclass, fieldName, false);
			bool flag = AndroidReflection.IsPrimitive(Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<FieldType>()));
			FieldType fieldType;
			if (flag)
			{
				bool flag2 = Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<FieldType>()) == Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<int>());
				if (flag2)
				{
					fieldType = AndroidJNISafe.GetIntField(this.m_jobject, fieldID).Cast<FieldType>();
				}
				else
				{
					bool flag3 = Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<FieldType>()) == Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<bool>());
					if (flag3)
					{
						fieldType = AndroidJNISafe.GetBooleanField(this.m_jobject, fieldID).Cast<FieldType>();
					}
					else
					{
						bool flag4 = Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<FieldType>()) == Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<byte>());
						if (flag4)
						{
							Debug.LogWarning("Field type <Byte> for Java get field call is obsolete, use field type <SByte> instead");
							fieldType = ((byte)AndroidJNISafe.GetSByteField(this.m_jobject, fieldID)).Cast<FieldType>();
						}
						else
						{
							bool flag5 = Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<FieldType>()) == Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<sbyte>());
							if (flag5)
							{
								fieldType = AndroidJNISafe.GetSByteField(this.m_jobject, fieldID).Cast<FieldType>();
							}
							else
							{
								bool flag6 = Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<FieldType>()) == Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<short>());
								if (flag6)
								{
									fieldType = AndroidJNISafe.GetShortField(this.m_jobject, fieldID).Cast<FieldType>();
								}
								else
								{
									bool flag7 = Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<FieldType>()) == Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<long>());
									if (flag7)
									{
										fieldType = AndroidJNISafe.GetLongField(this.m_jobject, fieldID).Cast<FieldType>();
									}
									else
									{
										bool flag8 = Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<FieldType>()) == Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<float>());
										if (flag8)
										{
											fieldType = AndroidJNISafe.GetFloatField(this.m_jobject, fieldID).Cast<FieldType>();
										}
										else
										{
											bool flag9 = Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<FieldType>()) == Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<double>());
											if (flag9)
											{
												fieldType = AndroidJNISafe.GetDoubleField(this.m_jobject, fieldID).Cast<FieldType>();
											}
											else
											{
												bool flag10 = Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<FieldType>()) == Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<char>());
												if (flag10)
												{
													fieldType = AndroidJNISafe.GetCharField(this.m_jobject, fieldID).Cast<FieldType>();
												}
												else
												{
													fieldType = default(FieldType);
												}
											}
										}
									}
								}
							}
						}
					}
				}
			}
			else
			{
				bool flag11 = Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<FieldType>()) == Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<string>());
				if (flag11)
				{
					fieldType = AndroidJNISafe.GetStringField(this.m_jobject, fieldID).Cast<FieldType>();
				}
				else
				{
					bool flag12 = Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<FieldType>()) == Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<AndroidJavaClass>());
					if (flag12)
					{
						IntPtr objectField = AndroidJNISafe.GetObjectField(this.m_jobject, fieldID);
						fieldType = ((objectField == IntPtr.Zero) ? default(FieldType) : AndroidJavaObject.AndroidJavaClassDeleteLocalRef(objectField).Cast<FieldType>());
					}
					else
					{
						bool flag13 = Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<FieldType>()) == Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<AndroidJavaObject>());
						if (flag13)
						{
							IntPtr objectField2 = AndroidJNISafe.GetObjectField(this.m_jobject, fieldID);
							fieldType = ((objectField2 == IntPtr.Zero) ? default(FieldType) : AndroidJavaObject.AndroidJavaObjectDeleteLocalRef(objectField2).Cast<FieldType>());
						}
						else
						{
							bool flag14 = AndroidReflection.IsAssignableFrom(Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<Array>()), Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<FieldType>()));
							if (!flag14)
							{
								string text = "JNI: Unknown field type '";
								Type typeFromHandle = Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<FieldType>());
								throw new Exception(String.Concat(text, (typeFromHandle != null) ? typeFromHandle.ToString() : null, "'"));
							}
							IntPtr objectField3 = AndroidJNISafe.GetObjectField(this.m_jobject, fieldID);
							fieldType = ((objectField3 == IntPtr.Zero) ? default(FieldType) : AndroidJNIHelper.ConvertFromJNIArray<FieldType>(objectField3).Cast<FieldType>());
						}
					}
				}
			}
			return fieldType;
		}

		// Token: 0x0600005F RID: 95 RVA: 0x00003FD0 File Offset: 0x000021D0
		public void _Set<FieldType>(string fieldName, FieldType val)
		{
			IntPtr fieldID = AndroidJNIHelper.GetFieldID<FieldType>(this.m_jclass, fieldName, false);
			bool flag = AndroidReflection.IsPrimitive(Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<FieldType>()));
			if (flag)
			{
				bool flag2 = Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<FieldType>()) == Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<int>());
				if (flag2)
				{
					AndroidJNISafe.SetIntField(this.m_jobject, fieldID, (int)((object)val));
				}
				else
				{
					bool flag3 = Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<FieldType>()) == Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<bool>());
					if (flag3)
					{
						AndroidJNISafe.SetBooleanField(this.m_jobject, fieldID, (bool)((object)val));
					}
					else
					{
						bool flag4 = Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<FieldType>()) == Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<byte>());
						if (flag4)
						{
							Debug.LogWarning("Field type <Byte> for Java set field call is obsolete, use field type <SByte> instead");
							AndroidJNISafe.SetSByteField(this.m_jobject, fieldID, (sbyte)((byte)((object)val)));
						}
						else
						{
							bool flag5 = Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<FieldType>()) == Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<sbyte>());
							if (flag5)
							{
								AndroidJNISafe.SetSByteField(this.m_jobject, fieldID, (sbyte)((object)val));
							}
							else
							{
								bool flag6 = Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<FieldType>()) == Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<short>());
								if (flag6)
								{
									AndroidJNISafe.SetShortField(this.m_jobject, fieldID, (short)((object)val));
								}
								else
								{
									bool flag7 = Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<FieldType>()) == Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<long>());
									if (flag7)
									{
										AndroidJNISafe.SetLongField(this.m_jobject, fieldID, (long)((object)val));
									}
									else
									{
										bool flag8 = Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<FieldType>()) == Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<float>());
										if (flag8)
										{
											AndroidJNISafe.SetFloatField(this.m_jobject, fieldID, (float)((object)val));
										}
										else
										{
											bool flag9 = Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<FieldType>()) == Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<double>());
											if (flag9)
											{
												AndroidJNISafe.SetDoubleField(this.m_jobject, fieldID, (double)((object)val));
											}
											else
											{
												bool flag10 = Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<FieldType>()) == Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<char>());
												if (flag10)
												{
													AndroidJNISafe.SetCharField(this.m_jobject, fieldID, (char)((object)val));
												}
											}
										}
									}
								}
							}
						}
					}
				}
			}
			else
			{
				bool flag11 = Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<FieldType>()) == Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<string>());
				if (flag11)
				{
					AndroidJNISafe.SetStringField(this.m_jobject, fieldID, val.Cast<string>());
				}
				else
				{
					bool flag12 = Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<FieldType>()) == Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<AndroidJavaClass>());
					if (flag12)
					{
						AndroidJNISafe.SetObjectField(this.m_jobject, fieldID, (val == null) ? IntPtr.Zero : val.Cast<AndroidJavaClass>().m_jclass);
					}
					else
					{
						bool flag13 = Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<FieldType>()) == Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<AndroidJavaObject>());
						if (flag13)
						{
							AndroidJNISafe.SetObjectField(this.m_jobject, fieldID, (val == null) ? IntPtr.Zero : val.Cast<AndroidJavaObject>().m_jobject);
						}
						else
						{
							bool flag14 = AndroidReflection.IsAssignableFrom(Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<Array>()), Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<FieldType>()));
							if (!flag14)
							{
								string text = "JNI: Unknown field type '";
								Type typeFromHandle = Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<FieldType>());
								throw new Exception(String.Concat(text, (typeFromHandle != null) ? typeFromHandle.ToString() : null, "'"));
							}
							IntPtr intPtr = AndroidJNIHelper.ConvertToJNIArray(val.Cast<Array>());
							AndroidJNISafe.SetObjectField(this.m_jclass, fieldID, intPtr);
						}
					}
				}
			}
		}

		// Token: 0x06000060 RID: 96 RVA: 0x000043A0 File Offset: 0x000025A0
		public void _SetStatic<FieldType>(string fieldName, FieldType val)
		{
			IntPtr fieldID = AndroidJNIHelper.GetFieldID<FieldType>(this.m_jclass, fieldName, true);
			bool flag = AndroidReflection.IsPrimitive(Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<FieldType>()));
			if (flag)
			{
				bool flag2 = Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<FieldType>()) == Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<int>());
				if (flag2)
				{
					AndroidJNISafe.SetStaticIntField(this.m_jclass, fieldID, (int)((object)val));
				}
				else
				{
					bool flag3 = Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<FieldType>()) == Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<bool>());
					if (flag3)
					{
						AndroidJNISafe.SetStaticBooleanField(this.m_jclass, fieldID, (bool)((object)val));
					}
					else
					{
						bool flag4 = Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<FieldType>()) == Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<byte>());
						if (flag4)
						{
							Debug.LogWarning("Field type <Byte> for Java set field call is obsolete, use field type <SByte> instead");
							AndroidJNISafe.SetStaticSByteField(this.m_jclass, fieldID, (sbyte)((byte)((object)val)));
						}
						else
						{
							bool flag5 = Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<FieldType>()) == Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<sbyte>());
							if (flag5)
							{
								AndroidJNISafe.SetStaticSByteField(this.m_jclass, fieldID, (sbyte)((object)val));
							}
							else
							{
								bool flag6 = Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<FieldType>()) == Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<short>());
								if (flag6)
								{
									AndroidJNISafe.SetStaticShortField(this.m_jclass, fieldID, (short)((object)val));
								}
								else
								{
									bool flag7 = Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<FieldType>()) == Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<long>());
									if (flag7)
									{
										AndroidJNISafe.SetStaticLongField(this.m_jclass, fieldID, (long)((object)val));
									}
									else
									{
										bool flag8 = Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<FieldType>()) == Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<float>());
										if (flag8)
										{
											AndroidJNISafe.SetStaticFloatField(this.m_jclass, fieldID, (float)((object)val));
										}
										else
										{
											bool flag9 = Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<FieldType>()) == Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<double>());
											if (flag9)
											{
												AndroidJNISafe.SetStaticDoubleField(this.m_jclass, fieldID, (double)((object)val));
											}
											else
											{
												bool flag10 = Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<FieldType>()) == Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<char>());
												if (flag10)
												{
													AndroidJNISafe.SetStaticCharField(this.m_jclass, fieldID, (char)((object)val));
												}
											}
										}
									}
								}
							}
						}
					}
				}
			}
			else
			{
				bool flag11 = Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<FieldType>()) == Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<string>());
				if (flag11)
				{
					AndroidJNISafe.SetStaticStringField(this.m_jclass, fieldID, val.Cast<string>());
				}
				else
				{
					bool flag12 = Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<FieldType>()) == Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<AndroidJavaClass>());
					if (flag12)
					{
						AndroidJNISafe.SetStaticObjectField(this.m_jclass, fieldID, (val == null) ? IntPtr.Zero : val.Cast<AndroidJavaClass>().m_jclass);
					}
					else
					{
						bool flag13 = Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<FieldType>()) == Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<AndroidJavaObject>());
						if (flag13)
						{
							AndroidJNISafe.SetStaticObjectField(this.m_jclass, fieldID, (val == null) ? IntPtr.Zero : val.Cast<AndroidJavaObject>().m_jobject);
						}
						else
						{
							bool flag14 = AndroidReflection.IsAssignableFrom(Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<Array>()), Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<FieldType>()));
							if (!flag14)
							{
								string text = "JNI: Unknown field type '";
								Type typeFromHandle = Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<FieldType>());
								throw new Exception(String.Concat(text, (typeFromHandle != null) ? typeFromHandle.ToString() : null, "'"));
							}
							IntPtr intPtr = AndroidJNIHelper.ConvertToJNIArray(val.Cast<Array>());
							AndroidJNISafe.SetStaticObjectField(this.m_jclass, fieldID, intPtr);
						}
					}
				}
			}
		}

		// Token: 0x04000018 RID: 24
		private static readonly IntPtr NativeFieldInfoPtr_enableDebugPrints;

		// Token: 0x04000019 RID: 25
		private static readonly IntPtr NativeFieldInfoPtr_m_jobject;

		// Token: 0x0400001A RID: 26
		private static readonly IntPtr NativeFieldInfoPtr_m_jclass;

		// Token: 0x0400001B RID: 27
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Il2CppReferenceArray_1_Object_0;

		// Token: 0x0400001C RID: 28
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		// Token: 0x0400001D RID: 29
		private static readonly IntPtr NativeMethodInfoPtr_Call_Public_Void_String_Il2CppReferenceArray_1_Object_0;

		// Token: 0x0400001E RID: 30
		private static readonly IntPtr NativeMethodInfoPtr_GetStatic_Public_FieldType_String_0;

		// Token: 0x0400001F RID: 31
		private static readonly IntPtr NativeMethodInfoPtr_GetRawObject_Public_IntPtr_0;

		// Token: 0x04000020 RID: 32
		private static readonly IntPtr NativeMethodInfoPtr_GetRawClass_Public_IntPtr_0;

		// Token: 0x04000021 RID: 33
		private static readonly IntPtr NativeMethodInfoPtr_Call_Public_ReturnType_String_Il2CppReferenceArray_1_Object_0;

		// Token: 0x04000022 RID: 34
		private static readonly IntPtr NativeMethodInfoPtr_CallStatic_Public_ReturnType_String_Il2CppReferenceArray_1_Object_0;

		// Token: 0x04000023 RID: 35
		private static readonly IntPtr NativeMethodInfoPtr_DebugPrint_Protected_Void_String_0;

		// Token: 0x04000024 RID: 36
		private static readonly IntPtr NativeMethodInfoPtr__AndroidJavaObject_Private_Void_String_Il2CppReferenceArray_1_Object_0;

		// Token: 0x04000025 RID: 37
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

		// Token: 0x04000026 RID: 38
		private static readonly IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;

		// Token: 0x04000027 RID: 39
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0;

		// Token: 0x04000028 RID: 40
		private static readonly IntPtr NativeMethodInfoPtr__Call_Protected_Void_String_Il2CppReferenceArray_1_Object_0;

		// Token: 0x04000029 RID: 41
		private static readonly IntPtr NativeMethodInfoPtr__Call_Protected_ReturnType_String_Il2CppReferenceArray_1_Object_0;

		// Token: 0x0400002A RID: 42
		private static readonly IntPtr NativeMethodInfoPtr__CallStatic_Protected_ReturnType_String_Il2CppReferenceArray_1_Object_0;

		// Token: 0x0400002B RID: 43
		private static readonly IntPtr NativeMethodInfoPtr__GetStatic_Protected_FieldType_String_0;

		// Token: 0x0400002C RID: 44
		private static readonly IntPtr NativeMethodInfoPtr_AndroidJavaObjectDeleteLocalRef_Internal_Static_AndroidJavaObject_IntPtr_0;

		// Token: 0x0400002D RID: 45
		private static readonly IntPtr NativeMethodInfoPtr_AndroidJavaClassDeleteLocalRef_Internal_Static_AndroidJavaClass_IntPtr_0;

		// Token: 0x0400002E RID: 46
		private static readonly IntPtr NativeMethodInfoPtr__GetRawObject_Protected_IntPtr_0;

		// Token: 0x0400002F RID: 47
		private static readonly IntPtr NativeMethodInfoPtr__GetRawClass_Protected_IntPtr_0;

		// Token: 0x0200001B RID: 27
		private sealed class MethodInfoStoreGeneric_GetStatic_Public_FieldType_String_0<FieldType>
		{
			// Token: 0x04000175 RID: 373
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(AndroidJavaObject.NativeMethodInfoPtr_GetStatic_Public_FieldType_String_0, Il2CppClassPointerStore<AndroidJavaObject>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<FieldType>.NativeClassPtr)) }))));
		}

		// Token: 0x0200001C RID: 28
		private sealed class MethodInfoStoreGeneric_Call_Public_ReturnType_String_Il2CppReferenceArray_1_Object_0<ReturnType>
		{
			// Token: 0x04000176 RID: 374
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(AndroidJavaObject.NativeMethodInfoPtr_Call_Public_ReturnType_String_Il2CppReferenceArray_1_Object_0, Il2CppClassPointerStore<AndroidJavaObject>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<ReturnType>.NativeClassPtr)) }))));
		}

		// Token: 0x0200001D RID: 29
		private sealed class MethodInfoStoreGeneric_CallStatic_Public_ReturnType_String_Il2CppReferenceArray_1_Object_0<ReturnType>
		{
			// Token: 0x04000177 RID: 375
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(AndroidJavaObject.NativeMethodInfoPtr_CallStatic_Public_ReturnType_String_Il2CppReferenceArray_1_Object_0, Il2CppClassPointerStore<AndroidJavaObject>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<ReturnType>.NativeClassPtr)) }))));
		}

		// Token: 0x0200001E RID: 30
		private sealed class MethodInfoStoreGeneric__Call_Protected_ReturnType_String_Il2CppReferenceArray_1_Object_0<ReturnType>
		{
			// Token: 0x04000178 RID: 376
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(AndroidJavaObject.NativeMethodInfoPtr__Call_Protected_ReturnType_String_Il2CppReferenceArray_1_Object_0, Il2CppClassPointerStore<AndroidJavaObject>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<ReturnType>.NativeClassPtr)) }))));
		}

		// Token: 0x0200001F RID: 31
		private sealed class MethodInfoStoreGeneric__CallStatic_Protected_ReturnType_String_Il2CppReferenceArray_1_Object_0<ReturnType>
		{
			// Token: 0x04000179 RID: 377
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(AndroidJavaObject.NativeMethodInfoPtr__CallStatic_Protected_ReturnType_String_Il2CppReferenceArray_1_Object_0, Il2CppClassPointerStore<AndroidJavaObject>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<ReturnType>.NativeClassPtr)) }))));
		}

		// Token: 0x02000020 RID: 32
		private sealed class MethodInfoStoreGeneric__GetStatic_Protected_FieldType_String_0<FieldType>
		{
			// Token: 0x0400017A RID: 378
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(AndroidJavaObject.NativeMethodInfoPtr__GetStatic_Protected_FieldType_String_0, Il2CppClassPointerStore<AndroidJavaObject>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<FieldType>.NativeClassPtr)) }))));
		}
	}
}
