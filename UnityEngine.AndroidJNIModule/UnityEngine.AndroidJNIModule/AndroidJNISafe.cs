using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x0200000E RID: 14
	public class AndroidJNISafe : Object
	{
		// Token: 0x06000159 RID: 345 RVA: 0x000080F0 File Offset: 0x000062F0
		// Note: this type is marked as 'beforefieldinit'.
		static AndroidJNISafe()
		{
			Il2CppClassPointerStore<AndroidJNISafe>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.AndroidJNIModule.dll", "UnityEngine", "AndroidJNISafe");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AndroidJNISafe>.NativeClassPtr);
			AndroidJNISafe.NativeMethodInfoPtr_CheckException_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNISafe>.NativeClassPtr, 100663461);
			AndroidJNISafe.NativeMethodInfoPtr_DeleteGlobalRef_Public_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNISafe>.NativeClassPtr, 100663462);
			AndroidJNISafe.NativeMethodInfoPtr_DeleteWeakGlobalRef_Public_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNISafe>.NativeClassPtr, 100663463);
			AndroidJNISafe.NativeMethodInfoPtr_DeleteLocalRef_Public_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNISafe>.NativeClassPtr, 100663464);
			AndroidJNISafe.NativeMethodInfoPtr_NewString_Public_Static_IntPtr_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNISafe>.NativeClassPtr, 100663465);
			AndroidJNISafe.NativeMethodInfoPtr_GetStringChars_Public_Static_String_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNISafe>.NativeClassPtr, 100663466);
			AndroidJNISafe.NativeMethodInfoPtr_GetObjectClass_Public_Static_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNISafe>.NativeClassPtr, 100663467);
			AndroidJNISafe.NativeMethodInfoPtr_GetStaticMethodID_Public_Static_IntPtr_IntPtr_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNISafe>.NativeClassPtr, 100663468);
			AndroidJNISafe.NativeMethodInfoPtr_GetMethodID_Public_Static_IntPtr_IntPtr_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNISafe>.NativeClassPtr, 100663469);
			AndroidJNISafe.NativeMethodInfoPtr_GetFieldID_Public_Static_IntPtr_IntPtr_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNISafe>.NativeClassPtr, 100663470);
			AndroidJNISafe.NativeMethodInfoPtr_GetStaticFieldID_Public_Static_IntPtr_IntPtr_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNISafe>.NativeClassPtr, 100663471);
			AndroidJNISafe.NativeMethodInfoPtr_FromReflectedMethod_Public_Static_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNISafe>.NativeClassPtr, 100663472);
			AndroidJNISafe.NativeMethodInfoPtr_FindClass_Public_Static_IntPtr_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNISafe>.NativeClassPtr, 100663473);
			AndroidJNISafe.NativeMethodInfoPtr_NewObject_Public_Static_IntPtr_IntPtr_IntPtr_Il2CppStructArray_1_jvalue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNISafe>.NativeClassPtr, 100663474);
			AndroidJNISafe.NativeMethodInfoPtr_GetStaticObjectField_Public_Static_IntPtr_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNISafe>.NativeClassPtr, 100663475);
			AndroidJNISafe.NativeMethodInfoPtr_GetStaticStringField_Public_Static_String_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNISafe>.NativeClassPtr, 100663476);
			AndroidJNISafe.NativeMethodInfoPtr_GetStaticCharField_Public_Static_Char_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNISafe>.NativeClassPtr, 100663477);
			AndroidJNISafe.NativeMethodInfoPtr_GetStaticDoubleField_Public_Static_Double_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNISafe>.NativeClassPtr, 100663478);
			AndroidJNISafe.NativeMethodInfoPtr_GetStaticFloatField_Public_Static_Single_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNISafe>.NativeClassPtr, 100663479);
			AndroidJNISafe.NativeMethodInfoPtr_GetStaticLongField_Public_Static_Int64_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNISafe>.NativeClassPtr, 100663480);
			AndroidJNISafe.NativeMethodInfoPtr_GetStaticShortField_Public_Static_Int16_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNISafe>.NativeClassPtr, 100663481);
			AndroidJNISafe.NativeMethodInfoPtr_GetStaticSByteField_Public_Static_SByte_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNISafe>.NativeClassPtr, 100663482);
			AndroidJNISafe.NativeMethodInfoPtr_GetStaticBooleanField_Public_Static_Boolean_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNISafe>.NativeClassPtr, 100663483);
			AndroidJNISafe.NativeMethodInfoPtr_GetStaticIntField_Public_Static_Int32_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNISafe>.NativeClassPtr, 100663484);
			AndroidJNISafe.NativeMethodInfoPtr_CallStaticVoidMethod_Public_Static_Void_IntPtr_IntPtr_Il2CppStructArray_1_jvalue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNISafe>.NativeClassPtr, 100663485);
			AndroidJNISafe.NativeMethodInfoPtr_CallStaticObjectMethod_Public_Static_IntPtr_IntPtr_IntPtr_Il2CppStructArray_1_jvalue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNISafe>.NativeClassPtr, 100663486);
			AndroidJNISafe.NativeMethodInfoPtr_CallStaticStringMethod_Public_Static_String_IntPtr_IntPtr_Il2CppStructArray_1_jvalue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNISafe>.NativeClassPtr, 100663487);
			AndroidJNISafe.NativeMethodInfoPtr_CallStaticCharMethod_Public_Static_Char_IntPtr_IntPtr_Il2CppStructArray_1_jvalue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNISafe>.NativeClassPtr, 100663488);
			AndroidJNISafe.NativeMethodInfoPtr_CallStaticDoubleMethod_Public_Static_Double_IntPtr_IntPtr_Il2CppStructArray_1_jvalue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNISafe>.NativeClassPtr, 100663489);
			AndroidJNISafe.NativeMethodInfoPtr_CallStaticFloatMethod_Public_Static_Single_IntPtr_IntPtr_Il2CppStructArray_1_jvalue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNISafe>.NativeClassPtr, 100663490);
			AndroidJNISafe.NativeMethodInfoPtr_CallStaticLongMethod_Public_Static_Int64_IntPtr_IntPtr_Il2CppStructArray_1_jvalue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNISafe>.NativeClassPtr, 100663491);
			AndroidJNISafe.NativeMethodInfoPtr_CallStaticShortMethod_Public_Static_Int16_IntPtr_IntPtr_Il2CppStructArray_1_jvalue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNISafe>.NativeClassPtr, 100663492);
			AndroidJNISafe.NativeMethodInfoPtr_CallStaticSByteMethod_Public_Static_SByte_IntPtr_IntPtr_Il2CppStructArray_1_jvalue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNISafe>.NativeClassPtr, 100663493);
			AndroidJNISafe.NativeMethodInfoPtr_CallStaticBooleanMethod_Public_Static_Boolean_IntPtr_IntPtr_Il2CppStructArray_1_jvalue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNISafe>.NativeClassPtr, 100663494);
			AndroidJNISafe.NativeMethodInfoPtr_CallStaticIntMethod_Public_Static_Int32_IntPtr_IntPtr_Il2CppStructArray_1_jvalue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNISafe>.NativeClassPtr, 100663495);
			AndroidJNISafe.NativeMethodInfoPtr_CallVoidMethod_Public_Static_Void_IntPtr_IntPtr_Il2CppStructArray_1_jvalue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNISafe>.NativeClassPtr, 100663496);
			AndroidJNISafe.NativeMethodInfoPtr_CallObjectMethod_Public_Static_IntPtr_IntPtr_IntPtr_Il2CppStructArray_1_jvalue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNISafe>.NativeClassPtr, 100663497);
			AndroidJNISafe.NativeMethodInfoPtr_CallStringMethod_Public_Static_String_IntPtr_IntPtr_Il2CppStructArray_1_jvalue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNISafe>.NativeClassPtr, 100663498);
			AndroidJNISafe.NativeMethodInfoPtr_CallCharMethod_Public_Static_Char_IntPtr_IntPtr_Il2CppStructArray_1_jvalue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNISafe>.NativeClassPtr, 100663499);
			AndroidJNISafe.NativeMethodInfoPtr_CallDoubleMethod_Public_Static_Double_IntPtr_IntPtr_Il2CppStructArray_1_jvalue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNISafe>.NativeClassPtr, 100663500);
			AndroidJNISafe.NativeMethodInfoPtr_CallFloatMethod_Public_Static_Single_IntPtr_IntPtr_Il2CppStructArray_1_jvalue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNISafe>.NativeClassPtr, 100663501);
			AndroidJNISafe.NativeMethodInfoPtr_CallLongMethod_Public_Static_Int64_IntPtr_IntPtr_Il2CppStructArray_1_jvalue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNISafe>.NativeClassPtr, 100663502);
			AndroidJNISafe.NativeMethodInfoPtr_CallShortMethod_Public_Static_Int16_IntPtr_IntPtr_Il2CppStructArray_1_jvalue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNISafe>.NativeClassPtr, 100663503);
			AndroidJNISafe.NativeMethodInfoPtr_CallSByteMethod_Public_Static_SByte_IntPtr_IntPtr_Il2CppStructArray_1_jvalue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNISafe>.NativeClassPtr, 100663504);
			AndroidJNISafe.NativeMethodInfoPtr_CallBooleanMethod_Public_Static_Boolean_IntPtr_IntPtr_Il2CppStructArray_1_jvalue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNISafe>.NativeClassPtr, 100663505);
			AndroidJNISafe.NativeMethodInfoPtr_CallIntMethod_Public_Static_Int32_IntPtr_IntPtr_Il2CppStructArray_1_jvalue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNISafe>.NativeClassPtr, 100663506);
			AndroidJNISafe.NativeMethodInfoPtr_FromCharArray_Public_Static_Il2CppStructArray_1_Char_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNISafe>.NativeClassPtr, 100663507);
			AndroidJNISafe.NativeMethodInfoPtr_FromDoubleArray_Public_Static_Il2CppStructArray_1_Double_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNISafe>.NativeClassPtr, 100663508);
			AndroidJNISafe.NativeMethodInfoPtr_FromFloatArray_Public_Static_Il2CppStructArray_1_Single_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNISafe>.NativeClassPtr, 100663509);
			AndroidJNISafe.NativeMethodInfoPtr_FromLongArray_Public_Static_Il2CppStructArray_1_Int64_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNISafe>.NativeClassPtr, 100663510);
			AndroidJNISafe.NativeMethodInfoPtr_FromShortArray_Public_Static_Il2CppStructArray_1_Int16_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNISafe>.NativeClassPtr, 100663511);
			AndroidJNISafe.NativeMethodInfoPtr_FromByteArray_Public_Static_Il2CppStructArray_1_Byte_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNISafe>.NativeClassPtr, 100663512);
			AndroidJNISafe.NativeMethodInfoPtr_FromSByteArray_Public_Static_Il2CppStructArray_1_SByte_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNISafe>.NativeClassPtr, 100663513);
			AndroidJNISafe.NativeMethodInfoPtr_FromBooleanArray_Public_Static_Il2CppStructArray_1_Boolean_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNISafe>.NativeClassPtr, 100663514);
			AndroidJNISafe.NativeMethodInfoPtr_FromIntArray_Public_Static_Il2CppStructArray_1_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNISafe>.NativeClassPtr, 100663515);
			AndroidJNISafe.NativeMethodInfoPtr_ToObjectArray_Public_Static_IntPtr_Il2CppStructArray_1_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNISafe>.NativeClassPtr, 100663516);
			AndroidJNISafe.NativeMethodInfoPtr_ToCharArray_Public_Static_IntPtr_Il2CppStructArray_1_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNISafe>.NativeClassPtr, 100663517);
			AndroidJNISafe.NativeMethodInfoPtr_ToDoubleArray_Public_Static_IntPtr_Il2CppStructArray_1_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNISafe>.NativeClassPtr, 100663518);
			AndroidJNISafe.NativeMethodInfoPtr_ToFloatArray_Public_Static_IntPtr_Il2CppStructArray_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNISafe>.NativeClassPtr, 100663519);
			AndroidJNISafe.NativeMethodInfoPtr_ToLongArray_Public_Static_IntPtr_Il2CppStructArray_1_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNISafe>.NativeClassPtr, 100663520);
			AndroidJNISafe.NativeMethodInfoPtr_ToShortArray_Public_Static_IntPtr_Il2CppStructArray_1_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNISafe>.NativeClassPtr, 100663521);
			AndroidJNISafe.NativeMethodInfoPtr_ToByteArray_Public_Static_IntPtr_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNISafe>.NativeClassPtr, 100663522);
			AndroidJNISafe.NativeMethodInfoPtr_ToSByteArray_Public_Static_IntPtr_Il2CppStructArray_1_SByte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNISafe>.NativeClassPtr, 100663523);
			AndroidJNISafe.NativeMethodInfoPtr_ToBooleanArray_Public_Static_IntPtr_Il2CppStructArray_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNISafe>.NativeClassPtr, 100663524);
			AndroidJNISafe.NativeMethodInfoPtr_ToIntArray_Public_Static_IntPtr_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNISafe>.NativeClassPtr, 100663525);
			AndroidJNISafe.NativeMethodInfoPtr_GetObjectArrayElement_Public_Static_IntPtr_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNISafe>.NativeClassPtr, 100663526);
			AndroidJNISafe.NativeMethodInfoPtr_GetArrayLength_Public_Static_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNISafe>.NativeClassPtr, 100663527);
		}

		// Token: 0x0600015A RID: 346 RVA: 0x0000865C File Offset: 0x0000685C
		[CallerCount(126)]
		[CachedScanResults(RefRangeStart = 129901, RefRangeEnd = 130027, XrefRangeStart = 129893, XrefRangeEnd = 129901, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CheckException()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNISafe.NativeMethodInfoPtr_CheckException_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600015B RID: 347 RVA: 0x00008684 File Offset: 0x00006884
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130027, XrefRangeEnd = 130031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DeleteGlobalRef(IntPtr globalref)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref globalref;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNISafe.NativeMethodInfoPtr_DeleteGlobalRef_Public_Static_Void_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600015C RID: 348 RVA: 0x000086B8 File Offset: 0x000068B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130031, XrefRangeEnd = 130035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DeleteWeakGlobalRef(IntPtr globalref)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref globalref;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNISafe.NativeMethodInfoPtr_DeleteWeakGlobalRef_Public_Static_Void_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600015D RID: 349 RVA: 0x000086EC File Offset: 0x000068EC
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 130039, RefRangeEnd = 130048, XrefRangeStart = 130035, XrefRangeEnd = 130039, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DeleteLocalRef(IntPtr localref)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref localref;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNISafe.NativeMethodInfoPtr_DeleteLocalRef_Public_Static_Void_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600015E RID: 350 RVA: 0x00008720 File Offset: 0x00006920
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 130053, RefRangeEnd = 130060, XrefRangeStart = 130048, XrefRangeEnd = 130053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr NewString(string chars)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(chars);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNISafe.NativeMethodInfoPtr_NewString_Public_Static_IntPtr_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600015F RID: 351 RVA: 0x00008764 File Offset: 0x00006964
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 130065, RefRangeEnd = 130067, XrefRangeStart = 130060, XrefRangeEnd = 130065, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetStringChars(IntPtr str)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref str;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNISafe.NativeMethodInfoPtr_GetStringChars_Public_Static_String_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000160 RID: 352 RVA: 0x0000879C File Offset: 0x0000699C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 130072, RefRangeEnd = 130073, XrefRangeStart = 130067, XrefRangeEnd = 130072, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr GetObjectClass(IntPtr ptr)
		{
			checked
			{
				IntPtr* ptr2 = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr2 = ref ptr;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNISafe.NativeMethodInfoPtr_GetObjectClass_Public_Static_IntPtr_IntPtr_0, 0, (void**)ptr2, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000161 RID: 353 RVA: 0x000087DC File Offset: 0x000069DC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 130078, RefRangeEnd = 130080, XrefRangeStart = 130073, XrefRangeEnd = 130078, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr GetStaticMethodID(IntPtr clazz, string name, string sig)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref clazz;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(sig);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNISafe.NativeMethodInfoPtr_GetStaticMethodID_Public_Static_IntPtr_IntPtr_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000162 RID: 354 RVA: 0x00008840 File Offset: 0x00006A40
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 130085, RefRangeEnd = 130088, XrefRangeStart = 130080, XrefRangeEnd = 130085, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr GetMethodID(IntPtr obj, string name, string sig)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref obj;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(sig);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNISafe.NativeMethodInfoPtr_GetMethodID_Public_Static_IntPtr_IntPtr_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000163 RID: 355 RVA: 0x000088A4 File Offset: 0x00006AA4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 130093, RefRangeEnd = 130094, XrefRangeStart = 130088, XrefRangeEnd = 130093, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr GetFieldID(IntPtr clazz, string name, string sig)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref clazz;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(sig);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNISafe.NativeMethodInfoPtr_GetFieldID_Public_Static_IntPtr_IntPtr_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000164 RID: 356 RVA: 0x00008908 File Offset: 0x00006B08
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 130099, RefRangeEnd = 130100, XrefRangeStart = 130094, XrefRangeEnd = 130099, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr GetStaticFieldID(IntPtr clazz, string name, string sig)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref clazz;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(sig);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNISafe.NativeMethodInfoPtr_GetStaticFieldID_Public_Static_IntPtr_IntPtr_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000165 RID: 357 RVA: 0x0000896C File Offset: 0x00006B6C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 130105, RefRangeEnd = 130107, XrefRangeStart = 130100, XrefRangeEnd = 130105, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr FromReflectedMethod(IntPtr refMethod)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref refMethod;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNISafe.NativeMethodInfoPtr_FromReflectedMethod_Public_Static_IntPtr_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000166 RID: 358 RVA: 0x000089AC File Offset: 0x00006BAC
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 130112, RefRangeEnd = 130120, XrefRangeStart = 130107, XrefRangeEnd = 130112, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr FindClass(string name)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNISafe.NativeMethodInfoPtr_FindClass_Public_Static_IntPtr_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000167 RID: 359 RVA: 0x000089F0 File Offset: 0x00006BF0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 130125, RefRangeEnd = 130126, XrefRangeStart = 130120, XrefRangeEnd = 130125, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr NewObject(IntPtr clazz, IntPtr methodID, Il2CppStructArray<jvalue> args)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref clazz;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref methodID;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNISafe.NativeMethodInfoPtr_NewObject_Public_Static_IntPtr_IntPtr_IntPtr_Il2CppStructArray_1_jvalue_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000168 RID: 360 RVA: 0x00008A50 File Offset: 0x00006C50
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 130131, RefRangeEnd = 130134, XrefRangeStart = 130126, XrefRangeEnd = 130131, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr GetStaticObjectField(IntPtr clazz, IntPtr fieldID)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref clazz;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fieldID;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNISafe.NativeMethodInfoPtr_GetStaticObjectField_Public_Static_IntPtr_IntPtr_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000169 RID: 361 RVA: 0x00008A9C File Offset: 0x00006C9C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 130139, RefRangeEnd = 130140, XrefRangeStart = 130134, XrefRangeEnd = 130139, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetStaticStringField(IntPtr clazz, IntPtr fieldID)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref clazz;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fieldID;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNISafe.NativeMethodInfoPtr_GetStaticStringField_Public_Static_String_IntPtr_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600016A RID: 362 RVA: 0x00008AE4 File Offset: 0x00006CE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130140, XrefRangeEnd = 130145, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static char GetStaticCharField(IntPtr clazz, IntPtr fieldID)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref clazz;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fieldID;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNISafe.NativeMethodInfoPtr_GetStaticCharField_Public_Static_Char_IntPtr_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600016B RID: 363 RVA: 0x00008B30 File Offset: 0x00006D30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130145, XrefRangeEnd = 130150, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static double GetStaticDoubleField(IntPtr clazz, IntPtr fieldID)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref clazz;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fieldID;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNISafe.NativeMethodInfoPtr_GetStaticDoubleField_Public_Static_Double_IntPtr_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600016C RID: 364 RVA: 0x00008B7C File Offset: 0x00006D7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130150, XrefRangeEnd = 130155, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float GetStaticFloatField(IntPtr clazz, IntPtr fieldID)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref clazz;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fieldID;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNISafe.NativeMethodInfoPtr_GetStaticFloatField_Public_Static_Single_IntPtr_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600016D RID: 365 RVA: 0x00008BC8 File Offset: 0x00006DC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130155, XrefRangeEnd = 130160, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static long GetStaticLongField(IntPtr clazz, IntPtr fieldID)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref clazz;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fieldID;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNISafe.NativeMethodInfoPtr_GetStaticLongField_Public_Static_Int64_IntPtr_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600016E RID: 366 RVA: 0x00008C14 File Offset: 0x00006E14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130160, XrefRangeEnd = 130165, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static short GetStaticShortField(IntPtr clazz, IntPtr fieldID)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref clazz;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fieldID;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNISafe.NativeMethodInfoPtr_GetStaticShortField_Public_Static_Int16_IntPtr_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600016F RID: 367 RVA: 0x00008C60 File Offset: 0x00006E60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130165, XrefRangeEnd = 130170, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static sbyte GetStaticSByteField(IntPtr clazz, IntPtr fieldID)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref clazz;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fieldID;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNISafe.NativeMethodInfoPtr_GetStaticSByteField_Public_Static_SByte_IntPtr_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000170 RID: 368 RVA: 0x00008CAC File Offset: 0x00006EAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130170, XrefRangeEnd = 130175, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetStaticBooleanField(IntPtr clazz, IntPtr fieldID)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref clazz;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fieldID;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNISafe.NativeMethodInfoPtr_GetStaticBooleanField_Public_Static_Boolean_IntPtr_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000171 RID: 369 RVA: 0x00008CF8 File Offset: 0x00006EF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130175, XrefRangeEnd = 130180, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetStaticIntField(IntPtr clazz, IntPtr fieldID)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref clazz;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fieldID;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNISafe.NativeMethodInfoPtr_GetStaticIntField_Public_Static_Int32_IntPtr_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000172 RID: 370 RVA: 0x00008D44 File Offset: 0x00006F44
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 130185, RefRangeEnd = 130186, XrefRangeStart = 130180, XrefRangeEnd = 130185, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CallStaticVoidMethod(IntPtr clazz, IntPtr methodID, Il2CppStructArray<jvalue> args)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref clazz;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref methodID;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNISafe.NativeMethodInfoPtr_CallStaticVoidMethod_Public_Static_Void_IntPtr_IntPtr_Il2CppStructArray_1_jvalue_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000173 RID: 371 RVA: 0x00008D98 File Offset: 0x00006F98
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 130191, RefRangeEnd = 130200, XrefRangeStart = 130186, XrefRangeEnd = 130191, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr CallStaticObjectMethod(IntPtr clazz, IntPtr methodID, Il2CppStructArray<jvalue> args)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref clazz;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref methodID;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNISafe.NativeMethodInfoPtr_CallStaticObjectMethod_Public_Static_IntPtr_IntPtr_IntPtr_Il2CppStructArray_1_jvalue_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000174 RID: 372 RVA: 0x00008DF8 File Offset: 0x00006FF8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 130205, RefRangeEnd = 130208, XrefRangeStart = 130200, XrefRangeEnd = 130205, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string CallStaticStringMethod(IntPtr clazz, IntPtr methodID, Il2CppStructArray<jvalue> args)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref clazz;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref methodID;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNISafe.NativeMethodInfoPtr_CallStaticStringMethod_Public_Static_String_IntPtr_IntPtr_Il2CppStructArray_1_jvalue_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000175 RID: 373 RVA: 0x00008E50 File Offset: 0x00007050
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 130213, RefRangeEnd = 130214, XrefRangeStart = 130208, XrefRangeEnd = 130213, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static char CallStaticCharMethod(IntPtr clazz, IntPtr methodID, Il2CppStructArray<jvalue> args)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref clazz;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref methodID;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNISafe.NativeMethodInfoPtr_CallStaticCharMethod_Public_Static_Char_IntPtr_IntPtr_Il2CppStructArray_1_jvalue_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000176 RID: 374 RVA: 0x00008EB0 File Offset: 0x000070B0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 130219, RefRangeEnd = 130220, XrefRangeStart = 130214, XrefRangeEnd = 130219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static double CallStaticDoubleMethod(IntPtr clazz, IntPtr methodID, Il2CppStructArray<jvalue> args)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref clazz;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref methodID;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNISafe.NativeMethodInfoPtr_CallStaticDoubleMethod_Public_Static_Double_IntPtr_IntPtr_Il2CppStructArray_1_jvalue_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000177 RID: 375 RVA: 0x00008F10 File Offset: 0x00007110
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 130225, RefRangeEnd = 130226, XrefRangeStart = 130220, XrefRangeEnd = 130225, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float CallStaticFloatMethod(IntPtr clazz, IntPtr methodID, Il2CppStructArray<jvalue> args)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref clazz;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref methodID;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNISafe.NativeMethodInfoPtr_CallStaticFloatMethod_Public_Static_Single_IntPtr_IntPtr_Il2CppStructArray_1_jvalue_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000178 RID: 376 RVA: 0x00008F70 File Offset: 0x00007170
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 130231, RefRangeEnd = 130232, XrefRangeStart = 130226, XrefRangeEnd = 130231, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static long CallStaticLongMethod(IntPtr clazz, IntPtr methodID, Il2CppStructArray<jvalue> args)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref clazz;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref methodID;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNISafe.NativeMethodInfoPtr_CallStaticLongMethod_Public_Static_Int64_IntPtr_IntPtr_Il2CppStructArray_1_jvalue_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000179 RID: 377 RVA: 0x00008FD0 File Offset: 0x000071D0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 130237, RefRangeEnd = 130238, XrefRangeStart = 130232, XrefRangeEnd = 130237, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static short CallStaticShortMethod(IntPtr clazz, IntPtr methodID, Il2CppStructArray<jvalue> args)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref clazz;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref methodID;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNISafe.NativeMethodInfoPtr_CallStaticShortMethod_Public_Static_Int16_IntPtr_IntPtr_Il2CppStructArray_1_jvalue_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600017A RID: 378 RVA: 0x00009030 File Offset: 0x00007230
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 130243, RefRangeEnd = 130245, XrefRangeStart = 130238, XrefRangeEnd = 130243, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static sbyte CallStaticSByteMethod(IntPtr clazz, IntPtr methodID, Il2CppStructArray<jvalue> args)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref clazz;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref methodID;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNISafe.NativeMethodInfoPtr_CallStaticSByteMethod_Public_Static_SByte_IntPtr_IntPtr_Il2CppStructArray_1_jvalue_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600017B RID: 379 RVA: 0x00009090 File Offset: 0x00007290
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 130250, RefRangeEnd = 130251, XrefRangeStart = 130245, XrefRangeEnd = 130250, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool CallStaticBooleanMethod(IntPtr clazz, IntPtr methodID, Il2CppStructArray<jvalue> args)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref clazz;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref methodID;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNISafe.NativeMethodInfoPtr_CallStaticBooleanMethod_Public_Static_Boolean_IntPtr_IntPtr_Il2CppStructArray_1_jvalue_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600017C RID: 380 RVA: 0x000090F0 File Offset: 0x000072F0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 130256, RefRangeEnd = 130257, XrefRangeStart = 130251, XrefRangeEnd = 130256, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int CallStaticIntMethod(IntPtr clazz, IntPtr methodID, Il2CppStructArray<jvalue> args)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref clazz;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref methodID;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNISafe.NativeMethodInfoPtr_CallStaticIntMethod_Public_Static_Int32_IntPtr_IntPtr_Il2CppStructArray_1_jvalue_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600017D RID: 381 RVA: 0x00009150 File Offset: 0x00007350
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 130262, RefRangeEnd = 130263, XrefRangeStart = 130257, XrefRangeEnd = 130262, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CallVoidMethod(IntPtr obj, IntPtr methodID, Il2CppStructArray<jvalue> args)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref obj;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref methodID;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNISafe.NativeMethodInfoPtr_CallVoidMethod_Public_Static_Void_IntPtr_IntPtr_Il2CppStructArray_1_jvalue_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600017E RID: 382 RVA: 0x000091A4 File Offset: 0x000073A4
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 130268, RefRangeEnd = 130273, XrefRangeStart = 130263, XrefRangeEnd = 130268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr CallObjectMethod(IntPtr obj, IntPtr methodID, Il2CppStructArray<jvalue> args)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref obj;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref methodID;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNISafe.NativeMethodInfoPtr_CallObjectMethod_Public_Static_IntPtr_IntPtr_IntPtr_Il2CppStructArray_1_jvalue_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600017F RID: 383 RVA: 0x00009204 File Offset: 0x00007404
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 130278, RefRangeEnd = 130279, XrefRangeStart = 130273, XrefRangeEnd = 130278, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string CallStringMethod(IntPtr obj, IntPtr methodID, Il2CppStructArray<jvalue> args)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref obj;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref methodID;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNISafe.NativeMethodInfoPtr_CallStringMethod_Public_Static_String_IntPtr_IntPtr_Il2CppStructArray_1_jvalue_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000180 RID: 384 RVA: 0x0000925C File Offset: 0x0000745C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 130284, RefRangeEnd = 130285, XrefRangeStart = 130279, XrefRangeEnd = 130284, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static char CallCharMethod(IntPtr obj, IntPtr methodID, Il2CppStructArray<jvalue> args)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref obj;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref methodID;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNISafe.NativeMethodInfoPtr_CallCharMethod_Public_Static_Char_IntPtr_IntPtr_Il2CppStructArray_1_jvalue_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000181 RID: 385 RVA: 0x000092BC File Offset: 0x000074BC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 130290, RefRangeEnd = 130291, XrefRangeStart = 130285, XrefRangeEnd = 130290, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static double CallDoubleMethod(IntPtr obj, IntPtr methodID, Il2CppStructArray<jvalue> args)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref obj;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref methodID;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNISafe.NativeMethodInfoPtr_CallDoubleMethod_Public_Static_Double_IntPtr_IntPtr_Il2CppStructArray_1_jvalue_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000182 RID: 386 RVA: 0x0000931C File Offset: 0x0000751C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 130296, RefRangeEnd = 130297, XrefRangeStart = 130291, XrefRangeEnd = 130296, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float CallFloatMethod(IntPtr obj, IntPtr methodID, Il2CppStructArray<jvalue> args)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref obj;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref methodID;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNISafe.NativeMethodInfoPtr_CallFloatMethod_Public_Static_Single_IntPtr_IntPtr_Il2CppStructArray_1_jvalue_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000183 RID: 387 RVA: 0x0000937C File Offset: 0x0000757C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 130302, RefRangeEnd = 130303, XrefRangeStart = 130297, XrefRangeEnd = 130302, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static long CallLongMethod(IntPtr obj, IntPtr methodID, Il2CppStructArray<jvalue> args)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref obj;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref methodID;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNISafe.NativeMethodInfoPtr_CallLongMethod_Public_Static_Int64_IntPtr_IntPtr_Il2CppStructArray_1_jvalue_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000184 RID: 388 RVA: 0x000093DC File Offset: 0x000075DC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 130308, RefRangeEnd = 130309, XrefRangeStart = 130303, XrefRangeEnd = 130308, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static short CallShortMethod(IntPtr obj, IntPtr methodID, Il2CppStructArray<jvalue> args)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref obj;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref methodID;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNISafe.NativeMethodInfoPtr_CallShortMethod_Public_Static_Int16_IntPtr_IntPtr_Il2CppStructArray_1_jvalue_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000185 RID: 389 RVA: 0x0000943C File Offset: 0x0000763C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 130314, RefRangeEnd = 130316, XrefRangeStart = 130309, XrefRangeEnd = 130314, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static sbyte CallSByteMethod(IntPtr obj, IntPtr methodID, Il2CppStructArray<jvalue> args)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref obj;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref methodID;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNISafe.NativeMethodInfoPtr_CallSByteMethod_Public_Static_SByte_IntPtr_IntPtr_Il2CppStructArray_1_jvalue_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000186 RID: 390 RVA: 0x0000949C File Offset: 0x0000769C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 130321, RefRangeEnd = 130322, XrefRangeStart = 130316, XrefRangeEnd = 130321, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool CallBooleanMethod(IntPtr obj, IntPtr methodID, Il2CppStructArray<jvalue> args)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref obj;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref methodID;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNISafe.NativeMethodInfoPtr_CallBooleanMethod_Public_Static_Boolean_IntPtr_IntPtr_Il2CppStructArray_1_jvalue_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000187 RID: 391 RVA: 0x000094FC File Offset: 0x000076FC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 130327, RefRangeEnd = 130328, XrefRangeStart = 130322, XrefRangeEnd = 130327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int CallIntMethod(IntPtr obj, IntPtr methodID, Il2CppStructArray<jvalue> args)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref obj;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref methodID;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNISafe.NativeMethodInfoPtr_CallIntMethod_Public_Static_Int32_IntPtr_IntPtr_Il2CppStructArray_1_jvalue_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000188 RID: 392 RVA: 0x0000955C File Offset: 0x0000775C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 130333, RefRangeEnd = 130334, XrefRangeStart = 130328, XrefRangeEnd = 130333, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<char> FromCharArray(IntPtr array)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref array;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNISafe.NativeMethodInfoPtr_FromCharArray_Public_Static_Il2CppStructArray_1_Char_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr3) : null;
			}
		}

		// Token: 0x06000189 RID: 393 RVA: 0x0000959C File Offset: 0x0000779C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 130339, RefRangeEnd = 130340, XrefRangeStart = 130334, XrefRangeEnd = 130339, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<double> FromDoubleArray(IntPtr array)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref array;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNISafe.NativeMethodInfoPtr_FromDoubleArray_Public_Static_Il2CppStructArray_1_Double_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<double>>(intPtr3) : null;
			}
		}

		// Token: 0x0600018A RID: 394 RVA: 0x000095DC File Offset: 0x000077DC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 130345, RefRangeEnd = 130346, XrefRangeStart = 130340, XrefRangeEnd = 130345, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<float> FromFloatArray(IntPtr array)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref array;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNISafe.NativeMethodInfoPtr_FromFloatArray_Public_Static_Il2CppStructArray_1_Single_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<float>>(intPtr3) : null;
			}
		}

		// Token: 0x0600018B RID: 395 RVA: 0x0000961C File Offset: 0x0000781C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 130351, RefRangeEnd = 130352, XrefRangeStart = 130346, XrefRangeEnd = 130351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<long> FromLongArray(IntPtr array)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref array;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNISafe.NativeMethodInfoPtr_FromLongArray_Public_Static_Il2CppStructArray_1_Int64_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<long>>(intPtr3) : null;
			}
		}

		// Token: 0x0600018C RID: 396 RVA: 0x0000965C File Offset: 0x0000785C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 130357, RefRangeEnd = 130358, XrefRangeStart = 130352, XrefRangeEnd = 130357, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<short> FromShortArray(IntPtr array)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref array;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNISafe.NativeMethodInfoPtr_FromShortArray_Public_Static_Il2CppStructArray_1_Int16_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<short>>(intPtr3) : null;
			}
		}

		// Token: 0x0600018D RID: 397 RVA: 0x0000969C File Offset: 0x0000789C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 130363, RefRangeEnd = 130364, XrefRangeStart = 130358, XrefRangeEnd = 130363, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<byte> FromByteArray(IntPtr array)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref array;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNISafe.NativeMethodInfoPtr_FromByteArray_Public_Static_Il2CppStructArray_1_Byte_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}
		}

		// Token: 0x0600018E RID: 398 RVA: 0x000096DC File Offset: 0x000078DC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 130369, RefRangeEnd = 130370, XrefRangeStart = 130364, XrefRangeEnd = 130369, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<sbyte> FromSByteArray(IntPtr array)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref array;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNISafe.NativeMethodInfoPtr_FromSByteArray_Public_Static_Il2CppStructArray_1_SByte_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<sbyte>>(intPtr3) : null;
			}
		}

		// Token: 0x0600018F RID: 399 RVA: 0x0000971C File Offset: 0x0000791C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 130375, RefRangeEnd = 130376, XrefRangeStart = 130370, XrefRangeEnd = 130375, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<bool> FromBooleanArray(IntPtr array)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref array;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNISafe.NativeMethodInfoPtr_FromBooleanArray_Public_Static_Il2CppStructArray_1_Boolean_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<bool>>(intPtr3) : null;
			}
		}

		// Token: 0x06000190 RID: 400 RVA: 0x0000975C File Offset: 0x0000795C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 130381, RefRangeEnd = 130382, XrefRangeStart = 130376, XrefRangeEnd = 130381, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<int> FromIntArray(IntPtr array)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref array;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNISafe.NativeMethodInfoPtr_FromIntArray_Public_Static_Il2CppStructArray_1_Int32_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr3) : null;
			}
		}

		// Token: 0x06000191 RID: 401 RVA: 0x0000979C File Offset: 0x0000799C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 130387, RefRangeEnd = 130388, XrefRangeStart = 130382, XrefRangeEnd = 130387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr ToObjectArray(Il2CppStructArray<IntPtr> array, IntPtr type)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref type;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNISafe.NativeMethodInfoPtr_ToObjectArray_Public_Static_IntPtr_Il2CppStructArray_1_IntPtr_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000192 RID: 402 RVA: 0x000097EC File Offset: 0x000079EC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 130393, RefRangeEnd = 130394, XrefRangeStart = 130388, XrefRangeEnd = 130393, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr ToCharArray(Il2CppStructArray<char> array)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNISafe.NativeMethodInfoPtr_ToCharArray_Public_Static_IntPtr_Il2CppStructArray_1_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000193 RID: 403 RVA: 0x00009830 File Offset: 0x00007A30
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 130399, RefRangeEnd = 130400, XrefRangeStart = 130394, XrefRangeEnd = 130399, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr ToDoubleArray(Il2CppStructArray<double> array)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNISafe.NativeMethodInfoPtr_ToDoubleArray_Public_Static_IntPtr_Il2CppStructArray_1_Double_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000194 RID: 404 RVA: 0x00009874 File Offset: 0x00007A74
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 130405, RefRangeEnd = 130406, XrefRangeStart = 130400, XrefRangeEnd = 130405, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr ToFloatArray(Il2CppStructArray<float> array)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNISafe.NativeMethodInfoPtr_ToFloatArray_Public_Static_IntPtr_Il2CppStructArray_1_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000195 RID: 405 RVA: 0x000098B8 File Offset: 0x00007AB8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 130411, RefRangeEnd = 130412, XrefRangeStart = 130406, XrefRangeEnd = 130411, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr ToLongArray(Il2CppStructArray<long> array)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNISafe.NativeMethodInfoPtr_ToLongArray_Public_Static_IntPtr_Il2CppStructArray_1_Int64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000196 RID: 406 RVA: 0x000098FC File Offset: 0x00007AFC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 130417, RefRangeEnd = 130418, XrefRangeStart = 130412, XrefRangeEnd = 130417, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr ToShortArray(Il2CppStructArray<short> array)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNISafe.NativeMethodInfoPtr_ToShortArray_Public_Static_IntPtr_Il2CppStructArray_1_Int16_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000197 RID: 407 RVA: 0x00009940 File Offset: 0x00007B40
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 130423, RefRangeEnd = 130424, XrefRangeStart = 130418, XrefRangeEnd = 130423, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr ToByteArray(Il2CppStructArray<byte> array)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNISafe.NativeMethodInfoPtr_ToByteArray_Public_Static_IntPtr_Il2CppStructArray_1_Byte_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000198 RID: 408 RVA: 0x00009984 File Offset: 0x00007B84
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 130429, RefRangeEnd = 130430, XrefRangeStart = 130424, XrefRangeEnd = 130429, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr ToSByteArray(Il2CppStructArray<sbyte> array)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNISafe.NativeMethodInfoPtr_ToSByteArray_Public_Static_IntPtr_Il2CppStructArray_1_SByte_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000199 RID: 409 RVA: 0x000099C8 File Offset: 0x00007BC8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 130435, RefRangeEnd = 130436, XrefRangeStart = 130430, XrefRangeEnd = 130435, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr ToBooleanArray(Il2CppStructArray<bool> array)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNISafe.NativeMethodInfoPtr_ToBooleanArray_Public_Static_IntPtr_Il2CppStructArray_1_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600019A RID: 410 RVA: 0x00009A0C File Offset: 0x00007C0C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 130441, RefRangeEnd = 130442, XrefRangeStart = 130436, XrefRangeEnd = 130441, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr ToIntArray(Il2CppStructArray<int> array)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNISafe.NativeMethodInfoPtr_ToIntArray_Public_Static_IntPtr_Il2CppStructArray_1_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600019B RID: 411 RVA: 0x00009A50 File Offset: 0x00007C50
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 130447, RefRangeEnd = 130448, XrefRangeStart = 130442, XrefRangeEnd = 130447, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr GetObjectArrayElement(IntPtr array, int index)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref array;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNISafe.NativeMethodInfoPtr_GetObjectArrayElement_Public_Static_IntPtr_IntPtr_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600019C RID: 412 RVA: 0x00009A9C File Offset: 0x00007C9C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 130453, RefRangeEnd = 130458, XrefRangeStart = 130448, XrefRangeEnd = 130453, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetArrayLength(IntPtr array)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref array;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNISafe.NativeMethodInfoPtr_GetArrayLength_Public_Static_Int32_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600019D RID: 413 RVA: 0x000027D5 File Offset: 0x000009D5
		public AndroidJNISafe(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0600019E RID: 414 RVA: 0x00009ADC File Offset: 0x00007CDC
		public static IntPtr NewStringUTF(string bytes)
		{
			IntPtr intPtr;
			try
			{
				intPtr = AndroidJNI.NewStringUTF(bytes);
			}
			finally
			{
				AndroidJNISafe.CheckException();
			}
			return intPtr;
		}

		// Token: 0x0600019F RID: 415 RVA: 0x00009B10 File Offset: 0x00007D10
		public static string GetStringUTFChars(IntPtr str)
		{
			string stringUTFChars;
			try
			{
				stringUTFChars = AndroidJNI.GetStringUTFChars(str);
			}
			finally
			{
				AndroidJNISafe.CheckException();
			}
			return stringUTFChars;
		}

		// Token: 0x060001A0 RID: 416 RVA: 0x00009B44 File Offset: 0x00007D44
		public static IntPtr FromReflectedField(IntPtr refField)
		{
			IntPtr intPtr;
			try
			{
				intPtr = AndroidJNI.FromReflectedField(refField);
			}
			finally
			{
				AndroidJNISafe.CheckException();
			}
			return intPtr;
		}

		// Token: 0x060001A1 RID: 417 RVA: 0x00009B78 File Offset: 0x00007D78
		public static void SetStaticObjectField(IntPtr clazz, IntPtr fieldID, IntPtr val)
		{
			try
			{
				AndroidJNI.SetStaticObjectField(clazz, fieldID, val);
			}
			finally
			{
				AndroidJNISafe.CheckException();
			}
		}

		// Token: 0x060001A2 RID: 418 RVA: 0x00009BAC File Offset: 0x00007DAC
		public static void SetStaticStringField(IntPtr clazz, IntPtr fieldID, string val)
		{
			try
			{
				AndroidJNI.SetStaticStringField(clazz, fieldID, val);
			}
			finally
			{
				AndroidJNISafe.CheckException();
			}
		}

		// Token: 0x060001A3 RID: 419 RVA: 0x00009BE0 File Offset: 0x00007DE0
		public static void SetStaticCharField(IntPtr clazz, IntPtr fieldID, char val)
		{
			try
			{
				AndroidJNI.SetStaticCharField(clazz, fieldID, val);
			}
			finally
			{
				AndroidJNISafe.CheckException();
			}
		}

		// Token: 0x060001A4 RID: 420 RVA: 0x00009C14 File Offset: 0x00007E14
		public static void SetStaticDoubleField(IntPtr clazz, IntPtr fieldID, double val)
		{
			try
			{
				AndroidJNI.SetStaticDoubleField(clazz, fieldID, val);
			}
			finally
			{
				AndroidJNISafe.CheckException();
			}
		}

		// Token: 0x060001A5 RID: 421 RVA: 0x00009C48 File Offset: 0x00007E48
		public static void SetStaticFloatField(IntPtr clazz, IntPtr fieldID, float val)
		{
			try
			{
				AndroidJNI.SetStaticFloatField(clazz, fieldID, val);
			}
			finally
			{
				AndroidJNISafe.CheckException();
			}
		}

		// Token: 0x060001A6 RID: 422 RVA: 0x00009C7C File Offset: 0x00007E7C
		public static void SetStaticLongField(IntPtr clazz, IntPtr fieldID, long val)
		{
			try
			{
				AndroidJNI.SetStaticLongField(clazz, fieldID, val);
			}
			finally
			{
				AndroidJNISafe.CheckException();
			}
		}

		// Token: 0x060001A7 RID: 423 RVA: 0x00009CB0 File Offset: 0x00007EB0
		public static void SetStaticShortField(IntPtr clazz, IntPtr fieldID, short val)
		{
			try
			{
				AndroidJNI.SetStaticShortField(clazz, fieldID, val);
			}
			finally
			{
				AndroidJNISafe.CheckException();
			}
		}

		// Token: 0x060001A8 RID: 424 RVA: 0x00009CE4 File Offset: 0x00007EE4
		public static void SetStaticSByteField(IntPtr clazz, IntPtr fieldID, sbyte val)
		{
			try
			{
				AndroidJNI.SetStaticSByteField(clazz, fieldID, val);
			}
			finally
			{
				AndroidJNISafe.CheckException();
			}
		}

		// Token: 0x060001A9 RID: 425 RVA: 0x00009D18 File Offset: 0x00007F18
		public static void SetStaticBooleanField(IntPtr clazz, IntPtr fieldID, bool val)
		{
			try
			{
				AndroidJNI.SetStaticBooleanField(clazz, fieldID, val);
			}
			finally
			{
				AndroidJNISafe.CheckException();
			}
		}

		// Token: 0x060001AA RID: 426 RVA: 0x00009D4C File Offset: 0x00007F4C
		public static void SetStaticIntField(IntPtr clazz, IntPtr fieldID, int val)
		{
			try
			{
				AndroidJNI.SetStaticIntField(clazz, fieldID, val);
			}
			finally
			{
				AndroidJNISafe.CheckException();
			}
		}

		// Token: 0x060001AB RID: 427 RVA: 0x00009D80 File Offset: 0x00007F80
		public static void SetObjectField(IntPtr obj, IntPtr fieldID, IntPtr val)
		{
			try
			{
				AndroidJNI.SetObjectField(obj, fieldID, val);
			}
			finally
			{
				AndroidJNISafe.CheckException();
			}
		}

		// Token: 0x060001AC RID: 428 RVA: 0x00009DB4 File Offset: 0x00007FB4
		public static void SetStringField(IntPtr obj, IntPtr fieldID, string val)
		{
			try
			{
				AndroidJNI.SetStringField(obj, fieldID, val);
			}
			finally
			{
				AndroidJNISafe.CheckException();
			}
		}

		// Token: 0x060001AD RID: 429 RVA: 0x00009DE8 File Offset: 0x00007FE8
		public static void SetCharField(IntPtr obj, IntPtr fieldID, char val)
		{
			try
			{
				AndroidJNI.SetCharField(obj, fieldID, val);
			}
			finally
			{
				AndroidJNISafe.CheckException();
			}
		}

		// Token: 0x060001AE RID: 430 RVA: 0x00009E1C File Offset: 0x0000801C
		public static void SetDoubleField(IntPtr obj, IntPtr fieldID, double val)
		{
			try
			{
				AndroidJNI.SetDoubleField(obj, fieldID, val);
			}
			finally
			{
				AndroidJNISafe.CheckException();
			}
		}

		// Token: 0x060001AF RID: 431 RVA: 0x00009E50 File Offset: 0x00008050
		public static void SetFloatField(IntPtr obj, IntPtr fieldID, float val)
		{
			try
			{
				AndroidJNI.SetFloatField(obj, fieldID, val);
			}
			finally
			{
				AndroidJNISafe.CheckException();
			}
		}

		// Token: 0x060001B0 RID: 432 RVA: 0x00009E84 File Offset: 0x00008084
		public static void SetLongField(IntPtr obj, IntPtr fieldID, long val)
		{
			try
			{
				AndroidJNI.SetLongField(obj, fieldID, val);
			}
			finally
			{
				AndroidJNISafe.CheckException();
			}
		}

		// Token: 0x060001B1 RID: 433 RVA: 0x00009EB8 File Offset: 0x000080B8
		public static void SetShortField(IntPtr obj, IntPtr fieldID, short val)
		{
			try
			{
				AndroidJNI.SetShortField(obj, fieldID, val);
			}
			finally
			{
				AndroidJNISafe.CheckException();
			}
		}

		// Token: 0x060001B2 RID: 434 RVA: 0x00009EEC File Offset: 0x000080EC
		public static void SetSByteField(IntPtr obj, IntPtr fieldID, sbyte val)
		{
			try
			{
				AndroidJNI.SetSByteField(obj, fieldID, val);
			}
			finally
			{
				AndroidJNISafe.CheckException();
			}
		}

		// Token: 0x060001B3 RID: 435 RVA: 0x00009F20 File Offset: 0x00008120
		public static void SetBooleanField(IntPtr obj, IntPtr fieldID, bool val)
		{
			try
			{
				AndroidJNI.SetBooleanField(obj, fieldID, val);
			}
			finally
			{
				AndroidJNISafe.CheckException();
			}
		}

		// Token: 0x060001B4 RID: 436 RVA: 0x00009F54 File Offset: 0x00008154
		public static void SetIntField(IntPtr obj, IntPtr fieldID, int val)
		{
			try
			{
				AndroidJNI.SetIntField(obj, fieldID, val);
			}
			finally
			{
				AndroidJNISafe.CheckException();
			}
		}

		// Token: 0x060001B5 RID: 437 RVA: 0x00009F88 File Offset: 0x00008188
		public static IntPtr GetObjectField(IntPtr obj, IntPtr fieldID)
		{
			IntPtr objectField;
			try
			{
				objectField = AndroidJNI.GetObjectField(obj, fieldID);
			}
			finally
			{
				AndroidJNISafe.CheckException();
			}
			return objectField;
		}

		// Token: 0x060001B6 RID: 438 RVA: 0x00009FBC File Offset: 0x000081BC
		public static string GetStringField(IntPtr obj, IntPtr fieldID)
		{
			string stringField;
			try
			{
				stringField = AndroidJNI.GetStringField(obj, fieldID);
			}
			finally
			{
				AndroidJNISafe.CheckException();
			}
			return stringField;
		}

		// Token: 0x060001B7 RID: 439 RVA: 0x00009FF0 File Offset: 0x000081F0
		public static char GetCharField(IntPtr obj, IntPtr fieldID)
		{
			char charField;
			try
			{
				charField = AndroidJNI.GetCharField(obj, fieldID);
			}
			finally
			{
				AndroidJNISafe.CheckException();
			}
			return charField;
		}

		// Token: 0x060001B8 RID: 440 RVA: 0x0000A024 File Offset: 0x00008224
		public static double GetDoubleField(IntPtr obj, IntPtr fieldID)
		{
			double doubleField;
			try
			{
				doubleField = AndroidJNI.GetDoubleField(obj, fieldID);
			}
			finally
			{
				AndroidJNISafe.CheckException();
			}
			return doubleField;
		}

		// Token: 0x060001B9 RID: 441 RVA: 0x0000A058 File Offset: 0x00008258
		public static float GetFloatField(IntPtr obj, IntPtr fieldID)
		{
			float floatField;
			try
			{
				floatField = AndroidJNI.GetFloatField(obj, fieldID);
			}
			finally
			{
				AndroidJNISafe.CheckException();
			}
			return floatField;
		}

		// Token: 0x060001BA RID: 442 RVA: 0x0000A08C File Offset: 0x0000828C
		public static long GetLongField(IntPtr obj, IntPtr fieldID)
		{
			long longField;
			try
			{
				longField = AndroidJNI.GetLongField(obj, fieldID);
			}
			finally
			{
				AndroidJNISafe.CheckException();
			}
			return longField;
		}

		// Token: 0x060001BB RID: 443 RVA: 0x0000A0C0 File Offset: 0x000082C0
		public static short GetShortField(IntPtr obj, IntPtr fieldID)
		{
			short shortField;
			try
			{
				shortField = AndroidJNI.GetShortField(obj, fieldID);
			}
			finally
			{
				AndroidJNISafe.CheckException();
			}
			return shortField;
		}

		// Token: 0x060001BC RID: 444 RVA: 0x0000A0F4 File Offset: 0x000082F4
		public static sbyte GetSByteField(IntPtr obj, IntPtr fieldID)
		{
			sbyte sbyteField;
			try
			{
				sbyteField = AndroidJNI.GetSByteField(obj, fieldID);
			}
			finally
			{
				AndroidJNISafe.CheckException();
			}
			return sbyteField;
		}

		// Token: 0x060001BD RID: 445 RVA: 0x0000A128 File Offset: 0x00008328
		public static bool GetBooleanField(IntPtr obj, IntPtr fieldID)
		{
			bool booleanField;
			try
			{
				booleanField = AndroidJNI.GetBooleanField(obj, fieldID);
			}
			finally
			{
				AndroidJNISafe.CheckException();
			}
			return booleanField;
		}

		// Token: 0x060001BE RID: 446 RVA: 0x0000A15C File Offset: 0x0000835C
		public static int GetIntField(IntPtr obj, IntPtr fieldID)
		{
			int intField;
			try
			{
				intField = AndroidJNI.GetIntField(obj, fieldID);
			}
			finally
			{
				AndroidJNISafe.CheckException();
			}
			return intField;
		}

		// Token: 0x060001BF RID: 447 RVA: 0x0000A190 File Offset: 0x00008390
		public static Il2CppStructArray<IntPtr> FromObjectArray(IntPtr array)
		{
			Il2CppStructArray<IntPtr> il2CppStructArray;
			try
			{
				il2CppStructArray = AndroidJNI.FromObjectArray(array);
			}
			finally
			{
				AndroidJNISafe.CheckException();
			}
			return il2CppStructArray;
		}

		// Token: 0x060001C0 RID: 448 RVA: 0x0000A1C4 File Offset: 0x000083C4
		public static IntPtr ToObjectArray(Il2CppStructArray<IntPtr> array)
		{
			IntPtr intPtr;
			try
			{
				intPtr = AndroidJNI.ToObjectArray(array);
			}
			finally
			{
				AndroidJNISafe.CheckException();
			}
			return intPtr;
		}

		// Token: 0x04000113 RID: 275
		private static readonly IntPtr NativeMethodInfoPtr_CheckException_Public_Static_Void_0;

		// Token: 0x04000114 RID: 276
		private static readonly IntPtr NativeMethodInfoPtr_DeleteGlobalRef_Public_Static_Void_IntPtr_0;

		// Token: 0x04000115 RID: 277
		private static readonly IntPtr NativeMethodInfoPtr_DeleteWeakGlobalRef_Public_Static_Void_IntPtr_0;

		// Token: 0x04000116 RID: 278
		private static readonly IntPtr NativeMethodInfoPtr_DeleteLocalRef_Public_Static_Void_IntPtr_0;

		// Token: 0x04000117 RID: 279
		private static readonly IntPtr NativeMethodInfoPtr_NewString_Public_Static_IntPtr_String_0;

		// Token: 0x04000118 RID: 280
		private static readonly IntPtr NativeMethodInfoPtr_GetStringChars_Public_Static_String_IntPtr_0;

		// Token: 0x04000119 RID: 281
		private static readonly IntPtr NativeMethodInfoPtr_GetObjectClass_Public_Static_IntPtr_IntPtr_0;

		// Token: 0x0400011A RID: 282
		private static readonly IntPtr NativeMethodInfoPtr_GetStaticMethodID_Public_Static_IntPtr_IntPtr_String_String_0;

		// Token: 0x0400011B RID: 283
		private static readonly IntPtr NativeMethodInfoPtr_GetMethodID_Public_Static_IntPtr_IntPtr_String_String_0;

		// Token: 0x0400011C RID: 284
		private static readonly IntPtr NativeMethodInfoPtr_GetFieldID_Public_Static_IntPtr_IntPtr_String_String_0;

		// Token: 0x0400011D RID: 285
		private static readonly IntPtr NativeMethodInfoPtr_GetStaticFieldID_Public_Static_IntPtr_IntPtr_String_String_0;

		// Token: 0x0400011E RID: 286
		private static readonly IntPtr NativeMethodInfoPtr_FromReflectedMethod_Public_Static_IntPtr_IntPtr_0;

		// Token: 0x0400011F RID: 287
		private static readonly IntPtr NativeMethodInfoPtr_FindClass_Public_Static_IntPtr_String_0;

		// Token: 0x04000120 RID: 288
		private static readonly IntPtr NativeMethodInfoPtr_NewObject_Public_Static_IntPtr_IntPtr_IntPtr_Il2CppStructArray_1_jvalue_0;

		// Token: 0x04000121 RID: 289
		private static readonly IntPtr NativeMethodInfoPtr_GetStaticObjectField_Public_Static_IntPtr_IntPtr_IntPtr_0;

		// Token: 0x04000122 RID: 290
		private static readonly IntPtr NativeMethodInfoPtr_GetStaticStringField_Public_Static_String_IntPtr_IntPtr_0;

		// Token: 0x04000123 RID: 291
		private static readonly IntPtr NativeMethodInfoPtr_GetStaticCharField_Public_Static_Char_IntPtr_IntPtr_0;

		// Token: 0x04000124 RID: 292
		private static readonly IntPtr NativeMethodInfoPtr_GetStaticDoubleField_Public_Static_Double_IntPtr_IntPtr_0;

		// Token: 0x04000125 RID: 293
		private static readonly IntPtr NativeMethodInfoPtr_GetStaticFloatField_Public_Static_Single_IntPtr_IntPtr_0;

		// Token: 0x04000126 RID: 294
		private static readonly IntPtr NativeMethodInfoPtr_GetStaticLongField_Public_Static_Int64_IntPtr_IntPtr_0;

		// Token: 0x04000127 RID: 295
		private static readonly IntPtr NativeMethodInfoPtr_GetStaticShortField_Public_Static_Int16_IntPtr_IntPtr_0;

		// Token: 0x04000128 RID: 296
		private static readonly IntPtr NativeMethodInfoPtr_GetStaticSByteField_Public_Static_SByte_IntPtr_IntPtr_0;

		// Token: 0x04000129 RID: 297
		private static readonly IntPtr NativeMethodInfoPtr_GetStaticBooleanField_Public_Static_Boolean_IntPtr_IntPtr_0;

		// Token: 0x0400012A RID: 298
		private static readonly IntPtr NativeMethodInfoPtr_GetStaticIntField_Public_Static_Int32_IntPtr_IntPtr_0;

		// Token: 0x0400012B RID: 299
		private static readonly IntPtr NativeMethodInfoPtr_CallStaticVoidMethod_Public_Static_Void_IntPtr_IntPtr_Il2CppStructArray_1_jvalue_0;

		// Token: 0x0400012C RID: 300
		private static readonly IntPtr NativeMethodInfoPtr_CallStaticObjectMethod_Public_Static_IntPtr_IntPtr_IntPtr_Il2CppStructArray_1_jvalue_0;

		// Token: 0x0400012D RID: 301
		private static readonly IntPtr NativeMethodInfoPtr_CallStaticStringMethod_Public_Static_String_IntPtr_IntPtr_Il2CppStructArray_1_jvalue_0;

		// Token: 0x0400012E RID: 302
		private static readonly IntPtr NativeMethodInfoPtr_CallStaticCharMethod_Public_Static_Char_IntPtr_IntPtr_Il2CppStructArray_1_jvalue_0;

		// Token: 0x0400012F RID: 303
		private static readonly IntPtr NativeMethodInfoPtr_CallStaticDoubleMethod_Public_Static_Double_IntPtr_IntPtr_Il2CppStructArray_1_jvalue_0;

		// Token: 0x04000130 RID: 304
		private static readonly IntPtr NativeMethodInfoPtr_CallStaticFloatMethod_Public_Static_Single_IntPtr_IntPtr_Il2CppStructArray_1_jvalue_0;

		// Token: 0x04000131 RID: 305
		private static readonly IntPtr NativeMethodInfoPtr_CallStaticLongMethod_Public_Static_Int64_IntPtr_IntPtr_Il2CppStructArray_1_jvalue_0;

		// Token: 0x04000132 RID: 306
		private static readonly IntPtr NativeMethodInfoPtr_CallStaticShortMethod_Public_Static_Int16_IntPtr_IntPtr_Il2CppStructArray_1_jvalue_0;

		// Token: 0x04000133 RID: 307
		private static readonly IntPtr NativeMethodInfoPtr_CallStaticSByteMethod_Public_Static_SByte_IntPtr_IntPtr_Il2CppStructArray_1_jvalue_0;

		// Token: 0x04000134 RID: 308
		private static readonly IntPtr NativeMethodInfoPtr_CallStaticBooleanMethod_Public_Static_Boolean_IntPtr_IntPtr_Il2CppStructArray_1_jvalue_0;

		// Token: 0x04000135 RID: 309
		private static readonly IntPtr NativeMethodInfoPtr_CallStaticIntMethod_Public_Static_Int32_IntPtr_IntPtr_Il2CppStructArray_1_jvalue_0;

		// Token: 0x04000136 RID: 310
		private static readonly IntPtr NativeMethodInfoPtr_CallVoidMethod_Public_Static_Void_IntPtr_IntPtr_Il2CppStructArray_1_jvalue_0;

		// Token: 0x04000137 RID: 311
		private static readonly IntPtr NativeMethodInfoPtr_CallObjectMethod_Public_Static_IntPtr_IntPtr_IntPtr_Il2CppStructArray_1_jvalue_0;

		// Token: 0x04000138 RID: 312
		private static readonly IntPtr NativeMethodInfoPtr_CallStringMethod_Public_Static_String_IntPtr_IntPtr_Il2CppStructArray_1_jvalue_0;

		// Token: 0x04000139 RID: 313
		private static readonly IntPtr NativeMethodInfoPtr_CallCharMethod_Public_Static_Char_IntPtr_IntPtr_Il2CppStructArray_1_jvalue_0;

		// Token: 0x0400013A RID: 314
		private static readonly IntPtr NativeMethodInfoPtr_CallDoubleMethod_Public_Static_Double_IntPtr_IntPtr_Il2CppStructArray_1_jvalue_0;

		// Token: 0x0400013B RID: 315
		private static readonly IntPtr NativeMethodInfoPtr_CallFloatMethod_Public_Static_Single_IntPtr_IntPtr_Il2CppStructArray_1_jvalue_0;

		// Token: 0x0400013C RID: 316
		private static readonly IntPtr NativeMethodInfoPtr_CallLongMethod_Public_Static_Int64_IntPtr_IntPtr_Il2CppStructArray_1_jvalue_0;

		// Token: 0x0400013D RID: 317
		private static readonly IntPtr NativeMethodInfoPtr_CallShortMethod_Public_Static_Int16_IntPtr_IntPtr_Il2CppStructArray_1_jvalue_0;

		// Token: 0x0400013E RID: 318
		private static readonly IntPtr NativeMethodInfoPtr_CallSByteMethod_Public_Static_SByte_IntPtr_IntPtr_Il2CppStructArray_1_jvalue_0;

		// Token: 0x0400013F RID: 319
		private static readonly IntPtr NativeMethodInfoPtr_CallBooleanMethod_Public_Static_Boolean_IntPtr_IntPtr_Il2CppStructArray_1_jvalue_0;

		// Token: 0x04000140 RID: 320
		private static readonly IntPtr NativeMethodInfoPtr_CallIntMethod_Public_Static_Int32_IntPtr_IntPtr_Il2CppStructArray_1_jvalue_0;

		// Token: 0x04000141 RID: 321
		private static readonly IntPtr NativeMethodInfoPtr_FromCharArray_Public_Static_Il2CppStructArray_1_Char_IntPtr_0;

		// Token: 0x04000142 RID: 322
		private static readonly IntPtr NativeMethodInfoPtr_FromDoubleArray_Public_Static_Il2CppStructArray_1_Double_IntPtr_0;

		// Token: 0x04000143 RID: 323
		private static readonly IntPtr NativeMethodInfoPtr_FromFloatArray_Public_Static_Il2CppStructArray_1_Single_IntPtr_0;

		// Token: 0x04000144 RID: 324
		private static readonly IntPtr NativeMethodInfoPtr_FromLongArray_Public_Static_Il2CppStructArray_1_Int64_IntPtr_0;

		// Token: 0x04000145 RID: 325
		private static readonly IntPtr NativeMethodInfoPtr_FromShortArray_Public_Static_Il2CppStructArray_1_Int16_IntPtr_0;

		// Token: 0x04000146 RID: 326
		private static readonly IntPtr NativeMethodInfoPtr_FromByteArray_Public_Static_Il2CppStructArray_1_Byte_IntPtr_0;

		// Token: 0x04000147 RID: 327
		private static readonly IntPtr NativeMethodInfoPtr_FromSByteArray_Public_Static_Il2CppStructArray_1_SByte_IntPtr_0;

		// Token: 0x04000148 RID: 328
		private static readonly IntPtr NativeMethodInfoPtr_FromBooleanArray_Public_Static_Il2CppStructArray_1_Boolean_IntPtr_0;

		// Token: 0x04000149 RID: 329
		private static readonly IntPtr NativeMethodInfoPtr_FromIntArray_Public_Static_Il2CppStructArray_1_Int32_IntPtr_0;

		// Token: 0x0400014A RID: 330
		private static readonly IntPtr NativeMethodInfoPtr_ToObjectArray_Public_Static_IntPtr_Il2CppStructArray_1_IntPtr_IntPtr_0;

		// Token: 0x0400014B RID: 331
		private static readonly IntPtr NativeMethodInfoPtr_ToCharArray_Public_Static_IntPtr_Il2CppStructArray_1_Char_0;

		// Token: 0x0400014C RID: 332
		private static readonly IntPtr NativeMethodInfoPtr_ToDoubleArray_Public_Static_IntPtr_Il2CppStructArray_1_Double_0;

		// Token: 0x0400014D RID: 333
		private static readonly IntPtr NativeMethodInfoPtr_ToFloatArray_Public_Static_IntPtr_Il2CppStructArray_1_Single_0;

		// Token: 0x0400014E RID: 334
		private static readonly IntPtr NativeMethodInfoPtr_ToLongArray_Public_Static_IntPtr_Il2CppStructArray_1_Int64_0;

		// Token: 0x0400014F RID: 335
		private static readonly IntPtr NativeMethodInfoPtr_ToShortArray_Public_Static_IntPtr_Il2CppStructArray_1_Int16_0;

		// Token: 0x04000150 RID: 336
		private static readonly IntPtr NativeMethodInfoPtr_ToByteArray_Public_Static_IntPtr_Il2CppStructArray_1_Byte_0;

		// Token: 0x04000151 RID: 337
		private static readonly IntPtr NativeMethodInfoPtr_ToSByteArray_Public_Static_IntPtr_Il2CppStructArray_1_SByte_0;

		// Token: 0x04000152 RID: 338
		private static readonly IntPtr NativeMethodInfoPtr_ToBooleanArray_Public_Static_IntPtr_Il2CppStructArray_1_Boolean_0;

		// Token: 0x04000153 RID: 339
		private static readonly IntPtr NativeMethodInfoPtr_ToIntArray_Public_Static_IntPtr_Il2CppStructArray_1_Int32_0;

		// Token: 0x04000154 RID: 340
		private static readonly IntPtr NativeMethodInfoPtr_GetObjectArrayElement_Public_Static_IntPtr_IntPtr_Int32_0;

		// Token: 0x04000155 RID: 341
		private static readonly IntPtr NativeMethodInfoPtr_GetArrayLength_Public_Static_Int32_IntPtr_0;
	}
}
