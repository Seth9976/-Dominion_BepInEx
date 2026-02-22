using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x0200000D RID: 13
	public static class AndroidJNI : Object
	{
		// Token: 0x060000B4 RID: 180 RVA: 0x00005E50 File Offset: 0x00004050
		// Note: this type is marked as 'beforefieldinit'.
		static AndroidJNI()
		{
			Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.AndroidJNIModule.dll", "UnityEngine", "AndroidJNI");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr);
			AndroidJNI.NativeMethodInfoPtr_FindClass_Public_Static_IntPtr_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663385);
			AndroidJNI.NativeMethodInfoPtr_FromReflectedMethod_Public_Static_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663386);
			AndroidJNI.NativeMethodInfoPtr_ExceptionOccurred_Public_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663387);
			AndroidJNI.NativeMethodInfoPtr_ExceptionClear_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663388);
			AndroidJNI.NativeMethodInfoPtr_PushLocalFrame_Public_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663389);
			AndroidJNI.NativeMethodInfoPtr_PopLocalFrame_Public_Static_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663390);
			AndroidJNI.NativeMethodInfoPtr_NewGlobalRef_Public_Static_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663391);
			AndroidJNI.NativeMethodInfoPtr_DeleteGlobalRef_Public_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663392);
			AndroidJNI.NativeMethodInfoPtr_NewWeakGlobalRef_Public_Static_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663393);
			AndroidJNI.NativeMethodInfoPtr_DeleteWeakGlobalRef_Public_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663394);
			AndroidJNI.NativeMethodInfoPtr_NewLocalRef_Public_Static_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663395);
			AndroidJNI.NativeMethodInfoPtr_DeleteLocalRef_Public_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663396);
			AndroidJNI.NativeMethodInfoPtr_NewObject_Public_Static_IntPtr_IntPtr_IntPtr_Il2CppStructArray_1_jvalue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663397);
			AndroidJNI.NativeMethodInfoPtr_GetObjectClass_Public_Static_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663398);
			AndroidJNI.NativeMethodInfoPtr_GetMethodID_Public_Static_IntPtr_IntPtr_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663399);
			AndroidJNI.NativeMethodInfoPtr_GetFieldID_Public_Static_IntPtr_IntPtr_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663400);
			AndroidJNI.NativeMethodInfoPtr_GetStaticMethodID_Public_Static_IntPtr_IntPtr_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663401);
			AndroidJNI.NativeMethodInfoPtr_GetStaticFieldID_Public_Static_IntPtr_IntPtr_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663402);
			AndroidJNI.NativeMethodInfoPtr_NewString_Public_Static_IntPtr_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663403);
			AndroidJNI.NativeMethodInfoPtr_NewStringFromStr_Private_Static_IntPtr_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663404);
			AndroidJNI.NativeMethodInfoPtr_GetStringChars_Public_Static_String_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663405);
			AndroidJNI.NativeMethodInfoPtr_CallStringMethod_Public_Static_String_IntPtr_IntPtr_Il2CppStructArray_1_jvalue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663406);
			AndroidJNI.NativeMethodInfoPtr_CallObjectMethod_Public_Static_IntPtr_IntPtr_IntPtr_Il2CppStructArray_1_jvalue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663407);
			AndroidJNI.NativeMethodInfoPtr_CallIntMethod_Public_Static_Int32_IntPtr_IntPtr_Il2CppStructArray_1_jvalue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663408);
			AndroidJNI.NativeMethodInfoPtr_CallBooleanMethod_Public_Static_Boolean_IntPtr_IntPtr_Il2CppStructArray_1_jvalue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663409);
			AndroidJNI.NativeMethodInfoPtr_CallShortMethod_Public_Static_Int16_IntPtr_IntPtr_Il2CppStructArray_1_jvalue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663410);
			AndroidJNI.NativeMethodInfoPtr_CallSByteMethod_Public_Static_SByte_IntPtr_IntPtr_Il2CppStructArray_1_jvalue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663411);
			AndroidJNI.NativeMethodInfoPtr_CallCharMethod_Public_Static_Char_IntPtr_IntPtr_Il2CppStructArray_1_jvalue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663412);
			AndroidJNI.NativeMethodInfoPtr_CallFloatMethod_Public_Static_Single_IntPtr_IntPtr_Il2CppStructArray_1_jvalue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663413);
			AndroidJNI.NativeMethodInfoPtr_CallDoubleMethod_Public_Static_Double_IntPtr_IntPtr_Il2CppStructArray_1_jvalue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663414);
			AndroidJNI.NativeMethodInfoPtr_CallLongMethod_Public_Static_Int64_IntPtr_IntPtr_Il2CppStructArray_1_jvalue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663415);
			AndroidJNI.NativeMethodInfoPtr_CallVoidMethod_Public_Static_Void_IntPtr_IntPtr_Il2CppStructArray_1_jvalue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663416);
			AndroidJNI.NativeMethodInfoPtr_CallStaticStringMethod_Public_Static_String_IntPtr_IntPtr_Il2CppStructArray_1_jvalue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663417);
			AndroidJNI.NativeMethodInfoPtr_CallStaticObjectMethod_Public_Static_IntPtr_IntPtr_IntPtr_Il2CppStructArray_1_jvalue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663418);
			AndroidJNI.NativeMethodInfoPtr_CallStaticIntMethod_Public_Static_Int32_IntPtr_IntPtr_Il2CppStructArray_1_jvalue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663419);
			AndroidJNI.NativeMethodInfoPtr_CallStaticBooleanMethod_Public_Static_Boolean_IntPtr_IntPtr_Il2CppStructArray_1_jvalue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663420);
			AndroidJNI.NativeMethodInfoPtr_CallStaticShortMethod_Public_Static_Int16_IntPtr_IntPtr_Il2CppStructArray_1_jvalue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663421);
			AndroidJNI.NativeMethodInfoPtr_CallStaticSByteMethod_Public_Static_SByte_IntPtr_IntPtr_Il2CppStructArray_1_jvalue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663422);
			AndroidJNI.NativeMethodInfoPtr_CallStaticCharMethod_Public_Static_Char_IntPtr_IntPtr_Il2CppStructArray_1_jvalue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663423);
			AndroidJNI.NativeMethodInfoPtr_CallStaticFloatMethod_Public_Static_Single_IntPtr_IntPtr_Il2CppStructArray_1_jvalue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663424);
			AndroidJNI.NativeMethodInfoPtr_CallStaticDoubleMethod_Public_Static_Double_IntPtr_IntPtr_Il2CppStructArray_1_jvalue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663425);
			AndroidJNI.NativeMethodInfoPtr_CallStaticLongMethod_Public_Static_Int64_IntPtr_IntPtr_Il2CppStructArray_1_jvalue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663426);
			AndroidJNI.NativeMethodInfoPtr_CallStaticVoidMethod_Public_Static_Void_IntPtr_IntPtr_Il2CppStructArray_1_jvalue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663427);
			AndroidJNI.NativeMethodInfoPtr_GetStaticStringField_Public_Static_String_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663428);
			AndroidJNI.NativeMethodInfoPtr_GetStaticObjectField_Public_Static_IntPtr_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663429);
			AndroidJNI.NativeMethodInfoPtr_GetStaticBooleanField_Public_Static_Boolean_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663430);
			AndroidJNI.NativeMethodInfoPtr_GetStaticSByteField_Public_Static_SByte_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663431);
			AndroidJNI.NativeMethodInfoPtr_GetStaticCharField_Public_Static_Char_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663432);
			AndroidJNI.NativeMethodInfoPtr_GetStaticShortField_Public_Static_Int16_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663433);
			AndroidJNI.NativeMethodInfoPtr_GetStaticIntField_Public_Static_Int32_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663434);
			AndroidJNI.NativeMethodInfoPtr_GetStaticLongField_Public_Static_Int64_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663435);
			AndroidJNI.NativeMethodInfoPtr_GetStaticFloatField_Public_Static_Single_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663436);
			AndroidJNI.NativeMethodInfoPtr_GetStaticDoubleField_Public_Static_Double_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663437);
			AndroidJNI.NativeMethodInfoPtr_ToBooleanArray_Public_Static_IntPtr_Il2CppStructArray_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663438);
			AndroidJNI.NativeMethodInfoPtr_ToByteArray_Public_Static_IntPtr_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663439);
			AndroidJNI.NativeMethodInfoPtr_ToSByteArray_Public_Static_IntPtr_Il2CppStructArray_1_SByte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663440);
			AndroidJNI.NativeMethodInfoPtr_ToCharArray_Public_Static_IntPtr_Il2CppStructArray_1_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663441);
			AndroidJNI.NativeMethodInfoPtr_ToShortArray_Public_Static_IntPtr_Il2CppStructArray_1_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663442);
			AndroidJNI.NativeMethodInfoPtr_ToIntArray_Public_Static_IntPtr_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663443);
			AndroidJNI.NativeMethodInfoPtr_ToLongArray_Public_Static_IntPtr_Il2CppStructArray_1_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663444);
			AndroidJNI.NativeMethodInfoPtr_ToFloatArray_Public_Static_IntPtr_Il2CppStructArray_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663445);
			AndroidJNI.NativeMethodInfoPtr_ToDoubleArray_Public_Static_IntPtr_Il2CppStructArray_1_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663446);
			AndroidJNI.NativeMethodInfoPtr_ToObjectArray_Public_Static_IntPtr_Il2CppStructArray_1_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663447);
			AndroidJNI.NativeMethodInfoPtr_FromBooleanArray_Public_Static_Il2CppStructArray_1_Boolean_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663448);
			AndroidJNI.NativeMethodInfoPtr_FromByteArray_Public_Static_Il2CppStructArray_1_Byte_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663449);
			AndroidJNI.NativeMethodInfoPtr_FromSByteArray_Public_Static_Il2CppStructArray_1_SByte_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663450);
			AndroidJNI.NativeMethodInfoPtr_FromCharArray_Public_Static_Il2CppStructArray_1_Char_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663451);
			AndroidJNI.NativeMethodInfoPtr_FromShortArray_Public_Static_Il2CppStructArray_1_Int16_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663452);
			AndroidJNI.NativeMethodInfoPtr_FromIntArray_Public_Static_Il2CppStructArray_1_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663453);
			AndroidJNI.NativeMethodInfoPtr_FromLongArray_Public_Static_Il2CppStructArray_1_Int64_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663454);
			AndroidJNI.NativeMethodInfoPtr_FromFloatArray_Public_Static_Il2CppStructArray_1_Single_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663455);
			AndroidJNI.NativeMethodInfoPtr_FromDoubleArray_Public_Static_Il2CppStructArray_1_Double_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663456);
			AndroidJNI.NativeMethodInfoPtr_GetArrayLength_Public_Static_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663457);
			AndroidJNI.NativeMethodInfoPtr_NewObjectArray_Public_Static_IntPtr_Int32_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663458);
			AndroidJNI.NativeMethodInfoPtr_GetObjectArrayElement_Public_Static_IntPtr_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663459);
			AndroidJNI.NativeMethodInfoPtr_SetObjectArrayElement_Public_Static_Void_IntPtr_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663460);
			AndroidJNI.AttachCurrentThreadDelegateField = IL2CPP.ResolveICall<AndroidJNI.AttachCurrentThreadDelegate>("UnityEngine.AndroidJNI::AttachCurrentThread");
			AndroidJNI.DetachCurrentThreadDelegateField = IL2CPP.ResolveICall<AndroidJNI.DetachCurrentThreadDelegate>("UnityEngine.AndroidJNI::DetachCurrentThread");
			AndroidJNI.GetVersionDelegateField = IL2CPP.ResolveICall<AndroidJNI.GetVersionDelegate>("UnityEngine.AndroidJNI::GetVersion");
			AndroidJNI.FromReflectedFieldDelegateField = IL2CPP.ResolveICall<AndroidJNI.FromReflectedFieldDelegate>("UnityEngine.AndroidJNI::FromReflectedField");
			AndroidJNI.ToReflectedMethodDelegateField = IL2CPP.ResolveICall<AndroidJNI.ToReflectedMethodDelegate>("UnityEngine.AndroidJNI::ToReflectedMethod");
			AndroidJNI.ToReflectedFieldDelegateField = IL2CPP.ResolveICall<AndroidJNI.ToReflectedFieldDelegate>("UnityEngine.AndroidJNI::ToReflectedField");
			AndroidJNI.GetSuperclassDelegateField = IL2CPP.ResolveICall<AndroidJNI.GetSuperclassDelegate>("UnityEngine.AndroidJNI::GetSuperclass");
			AndroidJNI.IsAssignableFromDelegateField = IL2CPP.ResolveICall<AndroidJNI.IsAssignableFromDelegate>("UnityEngine.AndroidJNI::IsAssignableFrom");
			AndroidJNI.ThrowDelegateField = IL2CPP.ResolveICall<AndroidJNI.ThrowDelegate>("UnityEngine.AndroidJNI::Throw");
			AndroidJNI.ThrowNewDelegateField = IL2CPP.ResolveICall<AndroidJNI.ThrowNewDelegate>("UnityEngine.AndroidJNI::ThrowNew");
			AndroidJNI.ExceptionDescribeDelegateField = IL2CPP.ResolveICall<AndroidJNI.ExceptionDescribeDelegate>("UnityEngine.AndroidJNI::ExceptionDescribe");
			AndroidJNI.FatalErrorDelegateField = IL2CPP.ResolveICall<AndroidJNI.FatalErrorDelegate>("UnityEngine.AndroidJNI::FatalError");
			AndroidJNI.IsSameObjectDelegateField = IL2CPP.ResolveICall<AndroidJNI.IsSameObjectDelegate>("UnityEngine.AndroidJNI::IsSameObject");
			AndroidJNI.EnsureLocalCapacityDelegateField = IL2CPP.ResolveICall<AndroidJNI.EnsureLocalCapacityDelegate>("UnityEngine.AndroidJNI::EnsureLocalCapacity");
			AndroidJNI.AllocObjectDelegateField = IL2CPP.ResolveICall<AndroidJNI.AllocObjectDelegate>("UnityEngine.AndroidJNI::AllocObject");
			AndroidJNI.IsInstanceOfDelegateField = IL2CPP.ResolveICall<AndroidJNI.IsInstanceOfDelegate>("UnityEngine.AndroidJNI::IsInstanceOf");
			AndroidJNI.NewStringDelegateField = IL2CPP.ResolveICall<AndroidJNI.NewStringDelegate>("UnityEngine.AndroidJNI::NewString");
			AndroidJNI.NewStringUTFDelegateField = IL2CPP.ResolveICall<AndroidJNI.NewStringUTFDelegate>("UnityEngine.AndroidJNI::NewStringUTF");
			AndroidJNI.GetStringLengthDelegateField = IL2CPP.ResolveICall<AndroidJNI.GetStringLengthDelegate>("UnityEngine.AndroidJNI::GetStringLength");
			AndroidJNI.GetStringUTFLengthDelegateField = IL2CPP.ResolveICall<AndroidJNI.GetStringUTFLengthDelegate>("UnityEngine.AndroidJNI::GetStringUTFLength");
			AndroidJNI.GetStringUTFCharsDelegateField = IL2CPP.ResolveICall<AndroidJNI.GetStringUTFCharsDelegate>("UnityEngine.AndroidJNI::GetStringUTFChars");
			AndroidJNI.GetStringFieldDelegateField = IL2CPP.ResolveICall<AndroidJNI.GetStringFieldDelegate>("UnityEngine.AndroidJNI::GetStringField");
			AndroidJNI.GetObjectFieldDelegateField = IL2CPP.ResolveICall<AndroidJNI.GetObjectFieldDelegate>("UnityEngine.AndroidJNI::GetObjectField");
			AndroidJNI.GetBooleanFieldDelegateField = IL2CPP.ResolveICall<AndroidJNI.GetBooleanFieldDelegate>("UnityEngine.AndroidJNI::GetBooleanField");
			AndroidJNI.GetSByteFieldDelegateField = IL2CPP.ResolveICall<AndroidJNI.GetSByteFieldDelegate>("UnityEngine.AndroidJNI::GetSByteField");
			AndroidJNI.GetCharFieldDelegateField = IL2CPP.ResolveICall<AndroidJNI.GetCharFieldDelegate>("UnityEngine.AndroidJNI::GetCharField");
			AndroidJNI.GetShortFieldDelegateField = IL2CPP.ResolveICall<AndroidJNI.GetShortFieldDelegate>("UnityEngine.AndroidJNI::GetShortField");
			AndroidJNI.GetIntFieldDelegateField = IL2CPP.ResolveICall<AndroidJNI.GetIntFieldDelegate>("UnityEngine.AndroidJNI::GetIntField");
			AndroidJNI.GetLongFieldDelegateField = IL2CPP.ResolveICall<AndroidJNI.GetLongFieldDelegate>("UnityEngine.AndroidJNI::GetLongField");
			AndroidJNI.GetFloatFieldDelegateField = IL2CPP.ResolveICall<AndroidJNI.GetFloatFieldDelegate>("UnityEngine.AndroidJNI::GetFloatField");
			AndroidJNI.GetDoubleFieldDelegateField = IL2CPP.ResolveICall<AndroidJNI.GetDoubleFieldDelegate>("UnityEngine.AndroidJNI::GetDoubleField");
			AndroidJNI.SetStringFieldDelegateField = IL2CPP.ResolveICall<AndroidJNI.SetStringFieldDelegate>("UnityEngine.AndroidJNI::SetStringField");
			AndroidJNI.SetObjectFieldDelegateField = IL2CPP.ResolveICall<AndroidJNI.SetObjectFieldDelegate>("UnityEngine.AndroidJNI::SetObjectField");
			AndroidJNI.SetBooleanFieldDelegateField = IL2CPP.ResolveICall<AndroidJNI.SetBooleanFieldDelegate>("UnityEngine.AndroidJNI::SetBooleanField");
			AndroidJNI.SetSByteFieldDelegateField = IL2CPP.ResolveICall<AndroidJNI.SetSByteFieldDelegate>("UnityEngine.AndroidJNI::SetSByteField");
			AndroidJNI.SetCharFieldDelegateField = IL2CPP.ResolveICall<AndroidJNI.SetCharFieldDelegate>("UnityEngine.AndroidJNI::SetCharField");
			AndroidJNI.SetShortFieldDelegateField = IL2CPP.ResolveICall<AndroidJNI.SetShortFieldDelegate>("UnityEngine.AndroidJNI::SetShortField");
			AndroidJNI.SetIntFieldDelegateField = IL2CPP.ResolveICall<AndroidJNI.SetIntFieldDelegate>("UnityEngine.AndroidJNI::SetIntField");
			AndroidJNI.SetLongFieldDelegateField = IL2CPP.ResolveICall<AndroidJNI.SetLongFieldDelegate>("UnityEngine.AndroidJNI::SetLongField");
			AndroidJNI.SetFloatFieldDelegateField = IL2CPP.ResolveICall<AndroidJNI.SetFloatFieldDelegate>("UnityEngine.AndroidJNI::SetFloatField");
			AndroidJNI.SetDoubleFieldDelegateField = IL2CPP.ResolveICall<AndroidJNI.SetDoubleFieldDelegate>("UnityEngine.AndroidJNI::SetDoubleField");
			AndroidJNI.SetStaticStringFieldDelegateField = IL2CPP.ResolveICall<AndroidJNI.SetStaticStringFieldDelegate>("UnityEngine.AndroidJNI::SetStaticStringField");
			AndroidJNI.SetStaticObjectFieldDelegateField = IL2CPP.ResolveICall<AndroidJNI.SetStaticObjectFieldDelegate>("UnityEngine.AndroidJNI::SetStaticObjectField");
			AndroidJNI.SetStaticBooleanFieldDelegateField = IL2CPP.ResolveICall<AndroidJNI.SetStaticBooleanFieldDelegate>("UnityEngine.AndroidJNI::SetStaticBooleanField");
			AndroidJNI.SetStaticSByteFieldDelegateField = IL2CPP.ResolveICall<AndroidJNI.SetStaticSByteFieldDelegate>("UnityEngine.AndroidJNI::SetStaticSByteField");
			AndroidJNI.SetStaticCharFieldDelegateField = IL2CPP.ResolveICall<AndroidJNI.SetStaticCharFieldDelegate>("UnityEngine.AndroidJNI::SetStaticCharField");
			AndroidJNI.SetStaticShortFieldDelegateField = IL2CPP.ResolveICall<AndroidJNI.SetStaticShortFieldDelegate>("UnityEngine.AndroidJNI::SetStaticShortField");
			AndroidJNI.SetStaticIntFieldDelegateField = IL2CPP.ResolveICall<AndroidJNI.SetStaticIntFieldDelegate>("UnityEngine.AndroidJNI::SetStaticIntField");
			AndroidJNI.SetStaticLongFieldDelegateField = IL2CPP.ResolveICall<AndroidJNI.SetStaticLongFieldDelegate>("UnityEngine.AndroidJNI::SetStaticLongField");
			AndroidJNI.SetStaticFloatFieldDelegateField = IL2CPP.ResolveICall<AndroidJNI.SetStaticFloatFieldDelegate>("UnityEngine.AndroidJNI::SetStaticFloatField");
			AndroidJNI.SetStaticDoubleFieldDelegateField = IL2CPP.ResolveICall<AndroidJNI.SetStaticDoubleFieldDelegate>("UnityEngine.AndroidJNI::SetStaticDoubleField");
			AndroidJNI.FromObjectArrayDelegateField = IL2CPP.ResolveICall<AndroidJNI.FromObjectArrayDelegate>("UnityEngine.AndroidJNI::FromObjectArray");
			AndroidJNI.NewBooleanArrayDelegateField = IL2CPP.ResolveICall<AndroidJNI.NewBooleanArrayDelegate>("UnityEngine.AndroidJNI::NewBooleanArray");
			AndroidJNI.NewSByteArrayDelegateField = IL2CPP.ResolveICall<AndroidJNI.NewSByteArrayDelegate>("UnityEngine.AndroidJNI::NewSByteArray");
			AndroidJNI.NewCharArrayDelegateField = IL2CPP.ResolveICall<AndroidJNI.NewCharArrayDelegate>("UnityEngine.AndroidJNI::NewCharArray");
			AndroidJNI.NewShortArrayDelegateField = IL2CPP.ResolveICall<AndroidJNI.NewShortArrayDelegate>("UnityEngine.AndroidJNI::NewShortArray");
			AndroidJNI.NewIntArrayDelegateField = IL2CPP.ResolveICall<AndroidJNI.NewIntArrayDelegate>("UnityEngine.AndroidJNI::NewIntArray");
			AndroidJNI.NewLongArrayDelegateField = IL2CPP.ResolveICall<AndroidJNI.NewLongArrayDelegate>("UnityEngine.AndroidJNI::NewLongArray");
			AndroidJNI.NewFloatArrayDelegateField = IL2CPP.ResolveICall<AndroidJNI.NewFloatArrayDelegate>("UnityEngine.AndroidJNI::NewFloatArray");
			AndroidJNI.NewDoubleArrayDelegateField = IL2CPP.ResolveICall<AndroidJNI.NewDoubleArrayDelegate>("UnityEngine.AndroidJNI::NewDoubleArray");
			AndroidJNI.GetBooleanArrayElementDelegateField = IL2CPP.ResolveICall<AndroidJNI.GetBooleanArrayElementDelegate>("UnityEngine.AndroidJNI::GetBooleanArrayElement");
			AndroidJNI.GetSByteArrayElementDelegateField = IL2CPP.ResolveICall<AndroidJNI.GetSByteArrayElementDelegate>("UnityEngine.AndroidJNI::GetSByteArrayElement");
			AndroidJNI.GetCharArrayElementDelegateField = IL2CPP.ResolveICall<AndroidJNI.GetCharArrayElementDelegate>("UnityEngine.AndroidJNI::GetCharArrayElement");
			AndroidJNI.GetShortArrayElementDelegateField = IL2CPP.ResolveICall<AndroidJNI.GetShortArrayElementDelegate>("UnityEngine.AndroidJNI::GetShortArrayElement");
			AndroidJNI.GetIntArrayElementDelegateField = IL2CPP.ResolveICall<AndroidJNI.GetIntArrayElementDelegate>("UnityEngine.AndroidJNI::GetIntArrayElement");
			AndroidJNI.GetLongArrayElementDelegateField = IL2CPP.ResolveICall<AndroidJNI.GetLongArrayElementDelegate>("UnityEngine.AndroidJNI::GetLongArrayElement");
			AndroidJNI.GetFloatArrayElementDelegateField = IL2CPP.ResolveICall<AndroidJNI.GetFloatArrayElementDelegate>("UnityEngine.AndroidJNI::GetFloatArrayElement");
			AndroidJNI.GetDoubleArrayElementDelegateField = IL2CPP.ResolveICall<AndroidJNI.GetDoubleArrayElementDelegate>("UnityEngine.AndroidJNI::GetDoubleArrayElement");
			AndroidJNI.SetBooleanArrayElementDelegateField = IL2CPP.ResolveICall<AndroidJNI.SetBooleanArrayElementDelegate>("UnityEngine.AndroidJNI::SetBooleanArrayElement");
			AndroidJNI.SetSByteArrayElementDelegateField = IL2CPP.ResolveICall<AndroidJNI.SetSByteArrayElementDelegate>("UnityEngine.AndroidJNI::SetSByteArrayElement");
			AndroidJNI.SetCharArrayElementDelegateField = IL2CPP.ResolveICall<AndroidJNI.SetCharArrayElementDelegate>("UnityEngine.AndroidJNI::SetCharArrayElement");
			AndroidJNI.SetShortArrayElementDelegateField = IL2CPP.ResolveICall<AndroidJNI.SetShortArrayElementDelegate>("UnityEngine.AndroidJNI::SetShortArrayElement");
			AndroidJNI.SetIntArrayElementDelegateField = IL2CPP.ResolveICall<AndroidJNI.SetIntArrayElementDelegate>("UnityEngine.AndroidJNI::SetIntArrayElement");
			AndroidJNI.SetLongArrayElementDelegateField = IL2CPP.ResolveICall<AndroidJNI.SetLongArrayElementDelegate>("UnityEngine.AndroidJNI::SetLongArrayElement");
			AndroidJNI.SetFloatArrayElementDelegateField = IL2CPP.ResolveICall<AndroidJNI.SetFloatArrayElementDelegate>("UnityEngine.AndroidJNI::SetFloatArrayElement");
			AndroidJNI.SetDoubleArrayElementDelegateField = IL2CPP.ResolveICall<AndroidJNI.SetDoubleArrayElementDelegate>("UnityEngine.AndroidJNI::SetDoubleArrayElement");
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x000068E4 File Offset: 0x00004AE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129739, XrefRangeEnd = 129741, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr FindClass(string name)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNI.NativeMethodInfoPtr_FindClass_Public_Static_IntPtr_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x00006928 File Offset: 0x00004B28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129741, XrefRangeEnd = 129743, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr FromReflectedMethod(IntPtr refMethod)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref refMethod;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNI.NativeMethodInfoPtr_FromReflectedMethod_Public_Static_IntPtr_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000B7 RID: 183 RVA: 0x00006968 File Offset: 0x00004B68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129743, XrefRangeEnd = 129745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr ExceptionOccurred()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNI.NativeMethodInfoPtr_ExceptionOccurred_Public_Static_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x00006998 File Offset: 0x00004B98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129745, XrefRangeEnd = 129747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ExceptionClear()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNI.NativeMethodInfoPtr_ExceptionClear_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x000069C0 File Offset: 0x00004BC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129747, XrefRangeEnd = 129749, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int PushLocalFrame(int capacity)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref capacity;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNI.NativeMethodInfoPtr_PushLocalFrame_Public_Static_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000BA RID: 186 RVA: 0x00006A00 File Offset: 0x00004C00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129749, XrefRangeEnd = 129751, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr PopLocalFrame(IntPtr ptr)
		{
			checked
			{
				IntPtr* ptr2 = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr2 = ref ptr;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNI.NativeMethodInfoPtr_PopLocalFrame_Public_Static_IntPtr_IntPtr_0, 0, (void**)ptr2, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000BB RID: 187 RVA: 0x00006A40 File Offset: 0x00004C40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129751, XrefRangeEnd = 129753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr NewGlobalRef(IntPtr obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref obj;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNI.NativeMethodInfoPtr_NewGlobalRef_Public_Static_IntPtr_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000BC RID: 188 RVA: 0x00006A80 File Offset: 0x00004C80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129753, XrefRangeEnd = 129755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DeleteGlobalRef(IntPtr obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref obj;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNI.NativeMethodInfoPtr_DeleteGlobalRef_Public_Static_Void_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000BD RID: 189 RVA: 0x00006AB4 File Offset: 0x00004CB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129755, XrefRangeEnd = 129757, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr NewWeakGlobalRef(IntPtr obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref obj;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNI.NativeMethodInfoPtr_NewWeakGlobalRef_Public_Static_IntPtr_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000BE RID: 190 RVA: 0x00006AF4 File Offset: 0x00004CF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129757, XrefRangeEnd = 129759, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DeleteWeakGlobalRef(IntPtr obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref obj;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNI.NativeMethodInfoPtr_DeleteWeakGlobalRef_Public_Static_Void_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000BF RID: 191 RVA: 0x00006B28 File Offset: 0x00004D28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129759, XrefRangeEnd = 129761, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr NewLocalRef(IntPtr obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref obj;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNI.NativeMethodInfoPtr_NewLocalRef_Public_Static_IntPtr_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x00006B68 File Offset: 0x00004D68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129761, XrefRangeEnd = 129763, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DeleteLocalRef(IntPtr obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref obj;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNI.NativeMethodInfoPtr_DeleteLocalRef_Public_Static_Void_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x00006B9C File Offset: 0x00004D9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129763, XrefRangeEnd = 129765, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNI.NativeMethodInfoPtr_NewObject_Public_Static_IntPtr_IntPtr_IntPtr_Il2CppStructArray_1_jvalue_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x00006BFC File Offset: 0x00004DFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129765, XrefRangeEnd = 129767, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr GetObjectClass(IntPtr obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref obj;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNI.NativeMethodInfoPtr_GetObjectClass_Public_Static_IntPtr_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x00006C3C File Offset: 0x00004E3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129767, XrefRangeEnd = 129769, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr GetMethodID(IntPtr clazz, string name, string sig)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNI.NativeMethodInfoPtr_GetMethodID_Public_Static_IntPtr_IntPtr_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x00006CA0 File Offset: 0x00004EA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129769, XrefRangeEnd = 129771, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNI.NativeMethodInfoPtr_GetFieldID_Public_Static_IntPtr_IntPtr_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x00006D04 File Offset: 0x00004F04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129771, XrefRangeEnd = 129773, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNI.NativeMethodInfoPtr_GetStaticMethodID_Public_Static_IntPtr_IntPtr_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x00006D68 File Offset: 0x00004F68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129773, XrefRangeEnd = 129775, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNI.NativeMethodInfoPtr_GetStaticFieldID_Public_Static_IntPtr_IntPtr_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x00006DCC File Offset: 0x00004FCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129775, XrefRangeEnd = 129777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr NewString(string chars)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(chars);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNI.NativeMethodInfoPtr_NewString_Public_Static_IntPtr_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000C8 RID: 200 RVA: 0x00006E10 File Offset: 0x00005010
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr NewStringFromStr(string chars)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(chars);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNI.NativeMethodInfoPtr_NewStringFromStr_Private_Static_IntPtr_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x00006E54 File Offset: 0x00005054
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129777, XrefRangeEnd = 129779, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetStringChars(IntPtr str)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref str;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNI.NativeMethodInfoPtr_GetStringChars_Public_Static_String_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060000CA RID: 202 RVA: 0x00006E8C File Offset: 0x0000508C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129779, XrefRangeEnd = 129781, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNI.NativeMethodInfoPtr_CallStringMethod_Public_Static_String_IntPtr_IntPtr_Il2CppStructArray_1_jvalue_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060000CB RID: 203 RVA: 0x00006EE4 File Offset: 0x000050E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129781, XrefRangeEnd = 129783, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNI.NativeMethodInfoPtr_CallObjectMethod_Public_Static_IntPtr_IntPtr_IntPtr_Il2CppStructArray_1_jvalue_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000CC RID: 204 RVA: 0x00006F44 File Offset: 0x00005144
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129783, XrefRangeEnd = 129785, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNI.NativeMethodInfoPtr_CallIntMethod_Public_Static_Int32_IntPtr_IntPtr_Il2CppStructArray_1_jvalue_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000CD RID: 205 RVA: 0x00006FA4 File Offset: 0x000051A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129785, XrefRangeEnd = 129787, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNI.NativeMethodInfoPtr_CallBooleanMethod_Public_Static_Boolean_IntPtr_IntPtr_Il2CppStructArray_1_jvalue_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000CE RID: 206 RVA: 0x00007004 File Offset: 0x00005204
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129787, XrefRangeEnd = 129789, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNI.NativeMethodInfoPtr_CallShortMethod_Public_Static_Int16_IntPtr_IntPtr_Il2CppStructArray_1_jvalue_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000CF RID: 207 RVA: 0x00007064 File Offset: 0x00005264
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129789, XrefRangeEnd = 129791, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNI.NativeMethodInfoPtr_CallSByteMethod_Public_Static_SByte_IntPtr_IntPtr_Il2CppStructArray_1_jvalue_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000D0 RID: 208 RVA: 0x000070C4 File Offset: 0x000052C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129791, XrefRangeEnd = 129793, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNI.NativeMethodInfoPtr_CallCharMethod_Public_Static_Char_IntPtr_IntPtr_Il2CppStructArray_1_jvalue_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000D1 RID: 209 RVA: 0x00007124 File Offset: 0x00005324
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129793, XrefRangeEnd = 129795, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNI.NativeMethodInfoPtr_CallFloatMethod_Public_Static_Single_IntPtr_IntPtr_Il2CppStructArray_1_jvalue_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000D2 RID: 210 RVA: 0x00007184 File Offset: 0x00005384
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129795, XrefRangeEnd = 129797, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNI.NativeMethodInfoPtr_CallDoubleMethod_Public_Static_Double_IntPtr_IntPtr_Il2CppStructArray_1_jvalue_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000D3 RID: 211 RVA: 0x000071E4 File Offset: 0x000053E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129797, XrefRangeEnd = 129799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNI.NativeMethodInfoPtr_CallLongMethod_Public_Static_Int64_IntPtr_IntPtr_Il2CppStructArray_1_jvalue_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x00007244 File Offset: 0x00005444
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129799, XrefRangeEnd = 129801, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNI.NativeMethodInfoPtr_CallVoidMethod_Public_Static_Void_IntPtr_IntPtr_Il2CppStructArray_1_jvalue_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000D5 RID: 213 RVA: 0x00007298 File Offset: 0x00005498
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129801, XrefRangeEnd = 129803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNI.NativeMethodInfoPtr_CallStaticStringMethod_Public_Static_String_IntPtr_IntPtr_Il2CppStructArray_1_jvalue_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060000D6 RID: 214 RVA: 0x000072F0 File Offset: 0x000054F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129803, XrefRangeEnd = 129805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNI.NativeMethodInfoPtr_CallStaticObjectMethod_Public_Static_IntPtr_IntPtr_IntPtr_Il2CppStructArray_1_jvalue_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000D7 RID: 215 RVA: 0x00007350 File Offset: 0x00005550
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129805, XrefRangeEnd = 129807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNI.NativeMethodInfoPtr_CallStaticIntMethod_Public_Static_Int32_IntPtr_IntPtr_Il2CppStructArray_1_jvalue_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000D8 RID: 216 RVA: 0x000073B0 File Offset: 0x000055B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129807, XrefRangeEnd = 129809, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNI.NativeMethodInfoPtr_CallStaticBooleanMethod_Public_Static_Boolean_IntPtr_IntPtr_Il2CppStructArray_1_jvalue_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000D9 RID: 217 RVA: 0x00007410 File Offset: 0x00005610
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129809, XrefRangeEnd = 129811, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNI.NativeMethodInfoPtr_CallStaticShortMethod_Public_Static_Int16_IntPtr_IntPtr_Il2CppStructArray_1_jvalue_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000DA RID: 218 RVA: 0x00007470 File Offset: 0x00005670
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129811, XrefRangeEnd = 129813, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNI.NativeMethodInfoPtr_CallStaticSByteMethod_Public_Static_SByte_IntPtr_IntPtr_Il2CppStructArray_1_jvalue_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000DB RID: 219 RVA: 0x000074D0 File Offset: 0x000056D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129813, XrefRangeEnd = 129815, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNI.NativeMethodInfoPtr_CallStaticCharMethod_Public_Static_Char_IntPtr_IntPtr_Il2CppStructArray_1_jvalue_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000DC RID: 220 RVA: 0x00007530 File Offset: 0x00005730
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129815, XrefRangeEnd = 129817, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNI.NativeMethodInfoPtr_CallStaticFloatMethod_Public_Static_Single_IntPtr_IntPtr_Il2CppStructArray_1_jvalue_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000DD RID: 221 RVA: 0x00007590 File Offset: 0x00005790
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129817, XrefRangeEnd = 129819, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNI.NativeMethodInfoPtr_CallStaticDoubleMethod_Public_Static_Double_IntPtr_IntPtr_Il2CppStructArray_1_jvalue_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000DE RID: 222 RVA: 0x000075F0 File Offset: 0x000057F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129819, XrefRangeEnd = 129821, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNI.NativeMethodInfoPtr_CallStaticLongMethod_Public_Static_Int64_IntPtr_IntPtr_Il2CppStructArray_1_jvalue_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000DF RID: 223 RVA: 0x00007650 File Offset: 0x00005850
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129821, XrefRangeEnd = 129823, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNI.NativeMethodInfoPtr_CallStaticVoidMethod_Public_Static_Void_IntPtr_IntPtr_Il2CppStructArray_1_jvalue_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000E0 RID: 224 RVA: 0x000076A4 File Offset: 0x000058A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129823, XrefRangeEnd = 129825, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNI.NativeMethodInfoPtr_GetStaticStringField_Public_Static_String_IntPtr_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060000E1 RID: 225 RVA: 0x000076EC File Offset: 0x000058EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129825, XrefRangeEnd = 129827, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNI.NativeMethodInfoPtr_GetStaticObjectField_Public_Static_IntPtr_IntPtr_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000E2 RID: 226 RVA: 0x00007738 File Offset: 0x00005938
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129827, XrefRangeEnd = 129829, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNI.NativeMethodInfoPtr_GetStaticBooleanField_Public_Static_Boolean_IntPtr_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x00007784 File Offset: 0x00005984
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129829, XrefRangeEnd = 129831, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNI.NativeMethodInfoPtr_GetStaticSByteField_Public_Static_SByte_IntPtr_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000E4 RID: 228 RVA: 0x000077D0 File Offset: 0x000059D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129831, XrefRangeEnd = 129833, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNI.NativeMethodInfoPtr_GetStaticCharField_Public_Static_Char_IntPtr_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000E5 RID: 229 RVA: 0x0000781C File Offset: 0x00005A1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129833, XrefRangeEnd = 129835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNI.NativeMethodInfoPtr_GetStaticShortField_Public_Static_Int16_IntPtr_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x00007868 File Offset: 0x00005A68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129835, XrefRangeEnd = 129837, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNI.NativeMethodInfoPtr_GetStaticIntField_Public_Static_Int32_IntPtr_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000E7 RID: 231 RVA: 0x000078B4 File Offset: 0x00005AB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129837, XrefRangeEnd = 129839, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNI.NativeMethodInfoPtr_GetStaticLongField_Public_Static_Int64_IntPtr_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000E8 RID: 232 RVA: 0x00007900 File Offset: 0x00005B00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129839, XrefRangeEnd = 129841, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNI.NativeMethodInfoPtr_GetStaticFloatField_Public_Static_Single_IntPtr_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000E9 RID: 233 RVA: 0x0000794C File Offset: 0x00005B4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129841, XrefRangeEnd = 129843, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNI.NativeMethodInfoPtr_GetStaticDoubleField_Public_Static_Double_IntPtr_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000EA RID: 234 RVA: 0x00007998 File Offset: 0x00005B98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129843, XrefRangeEnd = 129845, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr ToBooleanArray(Il2CppStructArray<bool> array)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNI.NativeMethodInfoPtr_ToBooleanArray_Public_Static_IntPtr_Il2CppStructArray_1_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000EB RID: 235 RVA: 0x000079DC File Offset: 0x00005BDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129845, XrefRangeEnd = 129847, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr ToByteArray(Il2CppStructArray<byte> array)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNI.NativeMethodInfoPtr_ToByteArray_Public_Static_IntPtr_Il2CppStructArray_1_Byte_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000EC RID: 236 RVA: 0x00007A20 File Offset: 0x00005C20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129847, XrefRangeEnd = 129849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr ToSByteArray(Il2CppStructArray<sbyte> array)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNI.NativeMethodInfoPtr_ToSByteArray_Public_Static_IntPtr_Il2CppStructArray_1_SByte_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000ED RID: 237 RVA: 0x00007A64 File Offset: 0x00005C64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129849, XrefRangeEnd = 129851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr ToCharArray(Il2CppStructArray<char> array)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNI.NativeMethodInfoPtr_ToCharArray_Public_Static_IntPtr_Il2CppStructArray_1_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000EE RID: 238 RVA: 0x00007AA8 File Offset: 0x00005CA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129851, XrefRangeEnd = 129853, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr ToShortArray(Il2CppStructArray<short> array)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNI.NativeMethodInfoPtr_ToShortArray_Public_Static_IntPtr_Il2CppStructArray_1_Int16_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000EF RID: 239 RVA: 0x00007AEC File Offset: 0x00005CEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129853, XrefRangeEnd = 129855, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr ToIntArray(Il2CppStructArray<int> array)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNI.NativeMethodInfoPtr_ToIntArray_Public_Static_IntPtr_Il2CppStructArray_1_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000F0 RID: 240 RVA: 0x00007B30 File Offset: 0x00005D30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129855, XrefRangeEnd = 129857, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr ToLongArray(Il2CppStructArray<long> array)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNI.NativeMethodInfoPtr_ToLongArray_Public_Static_IntPtr_Il2CppStructArray_1_Int64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000F1 RID: 241 RVA: 0x00007B74 File Offset: 0x00005D74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129857, XrefRangeEnd = 129859, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr ToFloatArray(Il2CppStructArray<float> array)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNI.NativeMethodInfoPtr_ToFloatArray_Public_Static_IntPtr_Il2CppStructArray_1_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000F2 RID: 242 RVA: 0x00007BB8 File Offset: 0x00005DB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129859, XrefRangeEnd = 129861, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr ToDoubleArray(Il2CppStructArray<double> array)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNI.NativeMethodInfoPtr_ToDoubleArray_Public_Static_IntPtr_Il2CppStructArray_1_Double_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000F3 RID: 243 RVA: 0x00007BFC File Offset: 0x00005DFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129861, XrefRangeEnd = 129863, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr ToObjectArray(Il2CppStructArray<IntPtr> array, IntPtr arrayClass)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref arrayClass;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNI.NativeMethodInfoPtr_ToObjectArray_Public_Static_IntPtr_Il2CppStructArray_1_IntPtr_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000F4 RID: 244 RVA: 0x00007C4C File Offset: 0x00005E4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129863, XrefRangeEnd = 129865, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<bool> FromBooleanArray(IntPtr array)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref array;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNI.NativeMethodInfoPtr_FromBooleanArray_Public_Static_Il2CppStructArray_1_Boolean_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<bool>>(intPtr3) : null;
			}
		}

		// Token: 0x060000F5 RID: 245 RVA: 0x00007C8C File Offset: 0x00005E8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129865, XrefRangeEnd = 129867, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<byte> FromByteArray(IntPtr array)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref array;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNI.NativeMethodInfoPtr_FromByteArray_Public_Static_Il2CppStructArray_1_Byte_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}
		}

		// Token: 0x060000F6 RID: 246 RVA: 0x00007CCC File Offset: 0x00005ECC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129867, XrefRangeEnd = 129869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<sbyte> FromSByteArray(IntPtr array)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref array;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNI.NativeMethodInfoPtr_FromSByteArray_Public_Static_Il2CppStructArray_1_SByte_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<sbyte>>(intPtr3) : null;
			}
		}

		// Token: 0x060000F7 RID: 247 RVA: 0x00007D0C File Offset: 0x00005F0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129869, XrefRangeEnd = 129871, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<char> FromCharArray(IntPtr array)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref array;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNI.NativeMethodInfoPtr_FromCharArray_Public_Static_Il2CppStructArray_1_Char_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr3) : null;
			}
		}

		// Token: 0x060000F8 RID: 248 RVA: 0x00007D4C File Offset: 0x00005F4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129871, XrefRangeEnd = 129873, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<short> FromShortArray(IntPtr array)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref array;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNI.NativeMethodInfoPtr_FromShortArray_Public_Static_Il2CppStructArray_1_Int16_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<short>>(intPtr3) : null;
			}
		}

		// Token: 0x060000F9 RID: 249 RVA: 0x00007D8C File Offset: 0x00005F8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129873, XrefRangeEnd = 129875, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<int> FromIntArray(IntPtr array)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref array;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNI.NativeMethodInfoPtr_FromIntArray_Public_Static_Il2CppStructArray_1_Int32_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr3) : null;
			}
		}

		// Token: 0x060000FA RID: 250 RVA: 0x00007DCC File Offset: 0x00005FCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129875, XrefRangeEnd = 129877, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<long> FromLongArray(IntPtr array)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref array;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNI.NativeMethodInfoPtr_FromLongArray_Public_Static_Il2CppStructArray_1_Int64_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<long>>(intPtr3) : null;
			}
		}

		// Token: 0x060000FB RID: 251 RVA: 0x00007E0C File Offset: 0x0000600C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129877, XrefRangeEnd = 129879, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<float> FromFloatArray(IntPtr array)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref array;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNI.NativeMethodInfoPtr_FromFloatArray_Public_Static_Il2CppStructArray_1_Single_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<float>>(intPtr3) : null;
			}
		}

		// Token: 0x060000FC RID: 252 RVA: 0x00007E4C File Offset: 0x0000604C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129879, XrefRangeEnd = 129881, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<double> FromDoubleArray(IntPtr array)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref array;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNI.NativeMethodInfoPtr_FromDoubleArray_Public_Static_Il2CppStructArray_1_Double_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<double>>(intPtr3) : null;
			}
		}

		// Token: 0x060000FD RID: 253 RVA: 0x00007E8C File Offset: 0x0000608C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129881, XrefRangeEnd = 129883, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetArrayLength(IntPtr array)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref array;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNI.NativeMethodInfoPtr_GetArrayLength_Public_Static_Int32_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000FE RID: 254 RVA: 0x00007ECC File Offset: 0x000060CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129883, XrefRangeEnd = 129885, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr NewObjectArray(int size, IntPtr clazz, IntPtr obj)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref size;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref clazz;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref obj;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNI.NativeMethodInfoPtr_NewObjectArray_Public_Static_IntPtr_Int32_IntPtr_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000FF RID: 255 RVA: 0x00007F28 File Offset: 0x00006128
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 129887, RefRangeEnd = 129891, XrefRangeStart = 129885, XrefRangeEnd = 129887, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNI.NativeMethodInfoPtr_GetObjectArrayElement_Public_Static_IntPtr_IntPtr_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000100 RID: 256 RVA: 0x00007F74 File Offset: 0x00006174
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129891, XrefRangeEnd = 129893, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetObjectArrayElement(IntPtr array, int index, IntPtr obj)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref array;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref obj;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNI.NativeMethodInfoPtr_SetObjectArrayElement_Public_Static_Void_IntPtr_Int32_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000101 RID: 257 RVA: 0x00002377 File Offset: 0x00000577
		public AndroidJNI(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06000102 RID: 258 RVA: 0x00002380 File Offset: 0x00000580
		public static int AttachCurrentThread()
		{
			return AndroidJNI.AttachCurrentThreadDelegateField();
		}

		// Token: 0x06000103 RID: 259 RVA: 0x0000238C File Offset: 0x0000058C
		public static int DetachCurrentThread()
		{
			return AndroidJNI.DetachCurrentThreadDelegateField();
		}

		// Token: 0x06000104 RID: 260 RVA: 0x00002398 File Offset: 0x00000598
		public static int GetVersion()
		{
			return AndroidJNI.GetVersionDelegateField();
		}

		// Token: 0x06000105 RID: 261 RVA: 0x000023A4 File Offset: 0x000005A4
		public static IntPtr FromReflectedField(IntPtr refField)
		{
			return AndroidJNI.FromReflectedFieldDelegateField(refField);
		}

		// Token: 0x06000106 RID: 262 RVA: 0x000023B1 File Offset: 0x000005B1
		public static IntPtr ToReflectedMethod(IntPtr clazz, IntPtr methodID, bool isStatic)
		{
			return AndroidJNI.ToReflectedMethodDelegateField(clazz, methodID, isStatic);
		}

		// Token: 0x06000107 RID: 263 RVA: 0x000023C0 File Offset: 0x000005C0
		public static IntPtr ToReflectedField(IntPtr clazz, IntPtr fieldID, bool isStatic)
		{
			return AndroidJNI.ToReflectedFieldDelegateField(clazz, fieldID, isStatic);
		}

		// Token: 0x06000108 RID: 264 RVA: 0x000023CF File Offset: 0x000005CF
		public static IntPtr GetSuperclass(IntPtr clazz)
		{
			return AndroidJNI.GetSuperclassDelegateField(clazz);
		}

		// Token: 0x06000109 RID: 265 RVA: 0x000023DC File Offset: 0x000005DC
		public static bool IsAssignableFrom(IntPtr clazz1, IntPtr clazz2)
		{
			return AndroidJNI.IsAssignableFromDelegateField(clazz1, clazz2);
		}

		// Token: 0x0600010A RID: 266 RVA: 0x000023EA File Offset: 0x000005EA
		public static int Throw(IntPtr obj)
		{
			return AndroidJNI.ThrowDelegateField(obj);
		}

		// Token: 0x0600010B RID: 267 RVA: 0x000023F7 File Offset: 0x000005F7
		public static int ThrowNew(IntPtr clazz, string message)
		{
			return AndroidJNI.ThrowNewDelegateField(clazz, IL2CPP.ManagedStringToIl2Cpp(message));
		}

		// Token: 0x0600010C RID: 268 RVA: 0x0000240A File Offset: 0x0000060A
		public static void ExceptionDescribe()
		{
			AndroidJNI.ExceptionDescribeDelegateField();
		}

		// Token: 0x0600010D RID: 269 RVA: 0x00002416 File Offset: 0x00000616
		public static void FatalError(string message)
		{
			AndroidJNI.FatalErrorDelegateField(IL2CPP.ManagedStringToIl2Cpp(message));
		}

		// Token: 0x0600010E RID: 270 RVA: 0x00002428 File Offset: 0x00000628
		public static bool IsSameObject(IntPtr obj1, IntPtr obj2)
		{
			return AndroidJNI.IsSameObjectDelegateField(obj1, obj2);
		}

		// Token: 0x0600010F RID: 271 RVA: 0x00002436 File Offset: 0x00000636
		public static int EnsureLocalCapacity(int capacity)
		{
			return AndroidJNI.EnsureLocalCapacityDelegateField(capacity);
		}

		// Token: 0x06000110 RID: 272 RVA: 0x00002443 File Offset: 0x00000643
		public static IntPtr AllocObject(IntPtr clazz)
		{
			return AndroidJNI.AllocObjectDelegateField(clazz);
		}

		// Token: 0x06000111 RID: 273 RVA: 0x00002450 File Offset: 0x00000650
		public static bool IsInstanceOf(IntPtr obj, IntPtr clazz)
		{
			return AndroidJNI.IsInstanceOfDelegateField(obj, clazz);
		}

		// Token: 0x06000112 RID: 274 RVA: 0x0000245E File Offset: 0x0000065E
		public static IntPtr NewString(Il2CppStructArray<char> chars)
		{
			return AndroidJNI.NewStringDelegateField(IL2CPP.Il2CppObjectBaseToPtr(chars));
		}

		// Token: 0x06000113 RID: 275 RVA: 0x00002470 File Offset: 0x00000670
		public static IntPtr NewStringUTF(string bytes)
		{
			return AndroidJNI.NewStringUTFDelegateField(IL2CPP.ManagedStringToIl2Cpp(bytes));
		}

		// Token: 0x06000114 RID: 276 RVA: 0x00002482 File Offset: 0x00000682
		public static int GetStringLength(IntPtr str)
		{
			return AndroidJNI.GetStringLengthDelegateField(str);
		}

		// Token: 0x06000115 RID: 277 RVA: 0x0000248F File Offset: 0x0000068F
		public static int GetStringUTFLength(IntPtr str)
		{
			return AndroidJNI.GetStringUTFLengthDelegateField(str);
		}

		// Token: 0x06000116 RID: 278 RVA: 0x00007FC4 File Offset: 0x000061C4
		public static string GetStringUTFChars(IntPtr str)
		{
			IntPtr intPtr = AndroidJNI.GetStringUTFCharsDelegateField(str);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000117 RID: 279 RVA: 0x00007FE4 File Offset: 0x000061E4
		public static byte CallByteMethod(IntPtr obj, IntPtr methodID, Il2CppStructArray<jvalue> args)
		{
			return (byte)AndroidJNI.CallSByteMethod(obj, methodID, args);
		}

		// Token: 0x06000118 RID: 280 RVA: 0x00008000 File Offset: 0x00006200
		public static string GetStringField(IntPtr obj, IntPtr fieldID)
		{
			IntPtr intPtr = AndroidJNI.GetStringFieldDelegateField(obj, fieldID);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000119 RID: 281 RVA: 0x0000249C File Offset: 0x0000069C
		public static IntPtr GetObjectField(IntPtr obj, IntPtr fieldID)
		{
			return AndroidJNI.GetObjectFieldDelegateField(obj, fieldID);
		}

		// Token: 0x0600011A RID: 282 RVA: 0x000024AA File Offset: 0x000006AA
		public static bool GetBooleanField(IntPtr obj, IntPtr fieldID)
		{
			return AndroidJNI.GetBooleanFieldDelegateField(obj, fieldID);
		}

		// Token: 0x0600011B RID: 283 RVA: 0x00008020 File Offset: 0x00006220
		public static byte GetByteField(IntPtr obj, IntPtr fieldID)
		{
			return (byte)AndroidJNI.GetSByteField(obj, fieldID);
		}

		// Token: 0x0600011C RID: 284 RVA: 0x000024B8 File Offset: 0x000006B8
		public static sbyte GetSByteField(IntPtr obj, IntPtr fieldID)
		{
			return AndroidJNI.GetSByteFieldDelegateField(obj, fieldID);
		}

		// Token: 0x0600011D RID: 285 RVA: 0x000024C6 File Offset: 0x000006C6
		public static char GetCharField(IntPtr obj, IntPtr fieldID)
		{
			return AndroidJNI.GetCharFieldDelegateField(obj, fieldID);
		}

		// Token: 0x0600011E RID: 286 RVA: 0x000024D4 File Offset: 0x000006D4
		public static short GetShortField(IntPtr obj, IntPtr fieldID)
		{
			return AndroidJNI.GetShortFieldDelegateField(obj, fieldID);
		}

		// Token: 0x0600011F RID: 287 RVA: 0x000024E2 File Offset: 0x000006E2
		public static int GetIntField(IntPtr obj, IntPtr fieldID)
		{
			return AndroidJNI.GetIntFieldDelegateField(obj, fieldID);
		}

		// Token: 0x06000120 RID: 288 RVA: 0x000024F0 File Offset: 0x000006F0
		public static long GetLongField(IntPtr obj, IntPtr fieldID)
		{
			return AndroidJNI.GetLongFieldDelegateField(obj, fieldID);
		}

		// Token: 0x06000121 RID: 289 RVA: 0x000024FE File Offset: 0x000006FE
		public static float GetFloatField(IntPtr obj, IntPtr fieldID)
		{
			return AndroidJNI.GetFloatFieldDelegateField(obj, fieldID);
		}

		// Token: 0x06000122 RID: 290 RVA: 0x0000250C File Offset: 0x0000070C
		public static double GetDoubleField(IntPtr obj, IntPtr fieldID)
		{
			return AndroidJNI.GetDoubleFieldDelegateField(obj, fieldID);
		}

		// Token: 0x06000123 RID: 291 RVA: 0x0000251A File Offset: 0x0000071A
		public static void SetStringField(IntPtr obj, IntPtr fieldID, string val)
		{
			AndroidJNI.SetStringFieldDelegateField(obj, fieldID, IL2CPP.ManagedStringToIl2Cpp(val));
		}

		// Token: 0x06000124 RID: 292 RVA: 0x0000252E File Offset: 0x0000072E
		public static void SetObjectField(IntPtr obj, IntPtr fieldID, IntPtr val)
		{
			AndroidJNI.SetObjectFieldDelegateField(obj, fieldID, val);
		}

		// Token: 0x06000125 RID: 293 RVA: 0x0000253D File Offset: 0x0000073D
		public static void SetBooleanField(IntPtr obj, IntPtr fieldID, bool val)
		{
			AndroidJNI.SetBooleanFieldDelegateField(obj, fieldID, val);
		}

		// Token: 0x06000126 RID: 294 RVA: 0x0000254C File Offset: 0x0000074C
		public static void SetByteField(IntPtr obj, IntPtr fieldID, byte val)
		{
			AndroidJNI.SetSByteField(obj, fieldID, (sbyte)val);
		}

		// Token: 0x06000127 RID: 295 RVA: 0x00002559 File Offset: 0x00000759
		public static void SetSByteField(IntPtr obj, IntPtr fieldID, sbyte val)
		{
			AndroidJNI.SetSByteFieldDelegateField(obj, fieldID, val);
		}

		// Token: 0x06000128 RID: 296 RVA: 0x00002568 File Offset: 0x00000768
		public static void SetCharField(IntPtr obj, IntPtr fieldID, char val)
		{
			AndroidJNI.SetCharFieldDelegateField(obj, fieldID, val);
		}

		// Token: 0x06000129 RID: 297 RVA: 0x00002577 File Offset: 0x00000777
		public static void SetShortField(IntPtr obj, IntPtr fieldID, short val)
		{
			AndroidJNI.SetShortFieldDelegateField(obj, fieldID, val);
		}

		// Token: 0x0600012A RID: 298 RVA: 0x00002586 File Offset: 0x00000786
		public static void SetIntField(IntPtr obj, IntPtr fieldID, int val)
		{
			AndroidJNI.SetIntFieldDelegateField(obj, fieldID, val);
		}

		// Token: 0x0600012B RID: 299 RVA: 0x00002595 File Offset: 0x00000795
		public static void SetLongField(IntPtr obj, IntPtr fieldID, long val)
		{
			AndroidJNI.SetLongFieldDelegateField(obj, fieldID, val);
		}

		// Token: 0x0600012C RID: 300 RVA: 0x000025A4 File Offset: 0x000007A4
		public static void SetFloatField(IntPtr obj, IntPtr fieldID, float val)
		{
			AndroidJNI.SetFloatFieldDelegateField(obj, fieldID, val);
		}

		// Token: 0x0600012D RID: 301 RVA: 0x000025B3 File Offset: 0x000007B3
		public static void SetDoubleField(IntPtr obj, IntPtr fieldID, double val)
		{
			AndroidJNI.SetDoubleFieldDelegateField(obj, fieldID, val);
		}

		// Token: 0x0600012E RID: 302 RVA: 0x0000803C File Offset: 0x0000623C
		public static byte CallStaticByteMethod(IntPtr clazz, IntPtr methodID, Il2CppStructArray<jvalue> args)
		{
			return (byte)AndroidJNI.CallStaticSByteMethod(clazz, methodID, args);
		}

		// Token: 0x0600012F RID: 303 RVA: 0x00008058 File Offset: 0x00006258
		public static byte GetStaticByteField(IntPtr clazz, IntPtr fieldID)
		{
			return (byte)AndroidJNI.GetStaticSByteField(clazz, fieldID);
		}

		// Token: 0x06000130 RID: 304 RVA: 0x000025C2 File Offset: 0x000007C2
		public static void SetStaticStringField(IntPtr clazz, IntPtr fieldID, string val)
		{
			AndroidJNI.SetStaticStringFieldDelegateField(clazz, fieldID, IL2CPP.ManagedStringToIl2Cpp(val));
		}

		// Token: 0x06000131 RID: 305 RVA: 0x000025D6 File Offset: 0x000007D6
		public static void SetStaticObjectField(IntPtr clazz, IntPtr fieldID, IntPtr val)
		{
			AndroidJNI.SetStaticObjectFieldDelegateField(clazz, fieldID, val);
		}

		// Token: 0x06000132 RID: 306 RVA: 0x000025E5 File Offset: 0x000007E5
		public static void SetStaticBooleanField(IntPtr clazz, IntPtr fieldID, bool val)
		{
			AndroidJNI.SetStaticBooleanFieldDelegateField(clazz, fieldID, val);
		}

		// Token: 0x06000133 RID: 307 RVA: 0x000025F4 File Offset: 0x000007F4
		public static void SetStaticByteField(IntPtr clazz, IntPtr fieldID, byte val)
		{
			AndroidJNI.SetStaticSByteField(clazz, fieldID, (sbyte)val);
		}

		// Token: 0x06000134 RID: 308 RVA: 0x00002601 File Offset: 0x00000801
		public static void SetStaticSByteField(IntPtr clazz, IntPtr fieldID, sbyte val)
		{
			AndroidJNI.SetStaticSByteFieldDelegateField(clazz, fieldID, val);
		}

		// Token: 0x06000135 RID: 309 RVA: 0x00002610 File Offset: 0x00000810
		public static void SetStaticCharField(IntPtr clazz, IntPtr fieldID, char val)
		{
			AndroidJNI.SetStaticCharFieldDelegateField(clazz, fieldID, val);
		}

		// Token: 0x06000136 RID: 310 RVA: 0x0000261F File Offset: 0x0000081F
		public static void SetStaticShortField(IntPtr clazz, IntPtr fieldID, short val)
		{
			AndroidJNI.SetStaticShortFieldDelegateField(clazz, fieldID, val);
		}

		// Token: 0x06000137 RID: 311 RVA: 0x0000262E File Offset: 0x0000082E
		public static void SetStaticIntField(IntPtr clazz, IntPtr fieldID, int val)
		{
			AndroidJNI.SetStaticIntFieldDelegateField(clazz, fieldID, val);
		}

		// Token: 0x06000138 RID: 312 RVA: 0x0000263D File Offset: 0x0000083D
		public static void SetStaticLongField(IntPtr clazz, IntPtr fieldID, long val)
		{
			AndroidJNI.SetStaticLongFieldDelegateField(clazz, fieldID, val);
		}

		// Token: 0x06000139 RID: 313 RVA: 0x0000264C File Offset: 0x0000084C
		public static void SetStaticFloatField(IntPtr clazz, IntPtr fieldID, float val)
		{
			AndroidJNI.SetStaticFloatFieldDelegateField(clazz, fieldID, val);
		}

		// Token: 0x0600013A RID: 314 RVA: 0x0000265B File Offset: 0x0000085B
		public static void SetStaticDoubleField(IntPtr clazz, IntPtr fieldID, double val)
		{
			AndroidJNI.SetStaticDoubleFieldDelegateField(clazz, fieldID, val);
		}

		// Token: 0x0600013B RID: 315 RVA: 0x00008074 File Offset: 0x00006274
		public static IntPtr ToObjectArray(Il2CppStructArray<IntPtr> array)
		{
			return AndroidJNI.ToObjectArray(array, IntPtr.Zero);
		}

		// Token: 0x0600013C RID: 316 RVA: 0x00008094 File Offset: 0x00006294
		public static Il2CppStructArray<IntPtr> FromObjectArray(IntPtr array)
		{
			IntPtr intPtr = AndroidJNI.FromObjectArrayDelegateField(array);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<IntPtr>>(intPtr2) : null;
		}

		// Token: 0x0600013D RID: 317 RVA: 0x0000266A File Offset: 0x0000086A
		public static IntPtr NewBooleanArray(int size)
		{
			return AndroidJNI.NewBooleanArrayDelegateField(size);
		}

		// Token: 0x0600013E RID: 318 RVA: 0x000080BC File Offset: 0x000062BC
		public static IntPtr NewByteArray(int size)
		{
			return AndroidJNI.NewSByteArray(size);
		}

		// Token: 0x0600013F RID: 319 RVA: 0x00002677 File Offset: 0x00000877
		public static IntPtr NewSByteArray(int size)
		{
			return AndroidJNI.NewSByteArrayDelegateField(size);
		}

		// Token: 0x06000140 RID: 320 RVA: 0x00002684 File Offset: 0x00000884
		public static IntPtr NewCharArray(int size)
		{
			return AndroidJNI.NewCharArrayDelegateField(size);
		}

		// Token: 0x06000141 RID: 321 RVA: 0x00002691 File Offset: 0x00000891
		public static IntPtr NewShortArray(int size)
		{
			return AndroidJNI.NewShortArrayDelegateField(size);
		}

		// Token: 0x06000142 RID: 322 RVA: 0x0000269E File Offset: 0x0000089E
		public static IntPtr NewIntArray(int size)
		{
			return AndroidJNI.NewIntArrayDelegateField(size);
		}

		// Token: 0x06000143 RID: 323 RVA: 0x000026AB File Offset: 0x000008AB
		public static IntPtr NewLongArray(int size)
		{
			return AndroidJNI.NewLongArrayDelegateField(size);
		}

		// Token: 0x06000144 RID: 324 RVA: 0x000026B8 File Offset: 0x000008B8
		public static IntPtr NewFloatArray(int size)
		{
			return AndroidJNI.NewFloatArrayDelegateField(size);
		}

		// Token: 0x06000145 RID: 325 RVA: 0x000026C5 File Offset: 0x000008C5
		public static IntPtr NewDoubleArray(int size)
		{
			return AndroidJNI.NewDoubleArrayDelegateField(size);
		}

		// Token: 0x06000146 RID: 326 RVA: 0x000026D2 File Offset: 0x000008D2
		public static bool GetBooleanArrayElement(IntPtr array, int index)
		{
			return AndroidJNI.GetBooleanArrayElementDelegateField(array, index);
		}

		// Token: 0x06000147 RID: 327 RVA: 0x000080D4 File Offset: 0x000062D4
		public static byte GetByteArrayElement(IntPtr array, int index)
		{
			return (byte)AndroidJNI.GetSByteArrayElement(array, index);
		}

		// Token: 0x06000148 RID: 328 RVA: 0x000026E0 File Offset: 0x000008E0
		public static sbyte GetSByteArrayElement(IntPtr array, int index)
		{
			return AndroidJNI.GetSByteArrayElementDelegateField(array, index);
		}

		// Token: 0x06000149 RID: 329 RVA: 0x000026EE File Offset: 0x000008EE
		public static char GetCharArrayElement(IntPtr array, int index)
		{
			return AndroidJNI.GetCharArrayElementDelegateField(array, index);
		}

		// Token: 0x0600014A RID: 330 RVA: 0x000026FC File Offset: 0x000008FC
		public static short GetShortArrayElement(IntPtr array, int index)
		{
			return AndroidJNI.GetShortArrayElementDelegateField(array, index);
		}

		// Token: 0x0600014B RID: 331 RVA: 0x0000270A File Offset: 0x0000090A
		public static int GetIntArrayElement(IntPtr array, int index)
		{
			return AndroidJNI.GetIntArrayElementDelegateField(array, index);
		}

		// Token: 0x0600014C RID: 332 RVA: 0x00002718 File Offset: 0x00000918
		public static long GetLongArrayElement(IntPtr array, int index)
		{
			return AndroidJNI.GetLongArrayElementDelegateField(array, index);
		}

		// Token: 0x0600014D RID: 333 RVA: 0x00002726 File Offset: 0x00000926
		public static float GetFloatArrayElement(IntPtr array, int index)
		{
			return AndroidJNI.GetFloatArrayElementDelegateField(array, index);
		}

		// Token: 0x0600014E RID: 334 RVA: 0x00002734 File Offset: 0x00000934
		public static double GetDoubleArrayElement(IntPtr array, int index)
		{
			return AndroidJNI.GetDoubleArrayElementDelegateField(array, index);
		}

		// Token: 0x0600014F RID: 335 RVA: 0x00002742 File Offset: 0x00000942
		public static void SetBooleanArrayElement(IntPtr array, int index, byte val)
		{
			AndroidJNI.SetBooleanArrayElement(array, index, val > 0);
		}

		// Token: 0x06000150 RID: 336 RVA: 0x00002751 File Offset: 0x00000951
		public static void SetBooleanArrayElement(IntPtr array, int index, bool val)
		{
			AndroidJNI.SetBooleanArrayElementDelegateField(array, index, val);
		}

		// Token: 0x06000151 RID: 337 RVA: 0x00002760 File Offset: 0x00000960
		public static void SetByteArrayElement(IntPtr array, int index, sbyte val)
		{
			AndroidJNI.SetSByteArrayElement(array, index, val);
		}

		// Token: 0x06000152 RID: 338 RVA: 0x0000276C File Offset: 0x0000096C
		public static void SetSByteArrayElement(IntPtr array, int index, sbyte val)
		{
			AndroidJNI.SetSByteArrayElementDelegateField(array, index, val);
		}

		// Token: 0x06000153 RID: 339 RVA: 0x0000277B File Offset: 0x0000097B
		public static void SetCharArrayElement(IntPtr array, int index, char val)
		{
			AndroidJNI.SetCharArrayElementDelegateField(array, index, val);
		}

		// Token: 0x06000154 RID: 340 RVA: 0x0000278A File Offset: 0x0000098A
		public static void SetShortArrayElement(IntPtr array, int index, short val)
		{
			AndroidJNI.SetShortArrayElementDelegateField(array, index, val);
		}

		// Token: 0x06000155 RID: 341 RVA: 0x00002799 File Offset: 0x00000999
		public static void SetIntArrayElement(IntPtr array, int index, int val)
		{
			AndroidJNI.SetIntArrayElementDelegateField(array, index, val);
		}

		// Token: 0x06000156 RID: 342 RVA: 0x000027A8 File Offset: 0x000009A8
		public static void SetLongArrayElement(IntPtr array, int index, long val)
		{
			AndroidJNI.SetLongArrayElementDelegateField(array, index, val);
		}

		// Token: 0x06000157 RID: 343 RVA: 0x000027B7 File Offset: 0x000009B7
		public static void SetFloatArrayElement(IntPtr array, int index, float val)
		{
			AndroidJNI.SetFloatArrayElementDelegateField(array, index, val);
		}

		// Token: 0x06000158 RID: 344 RVA: 0x000027C6 File Offset: 0x000009C6
		public static void SetDoubleArrayElement(IntPtr array, int index, double val)
		{
			AndroidJNI.SetDoubleArrayElementDelegateField(array, index, val);
		}

		// Token: 0x0400007B RID: 123
		private static readonly IntPtr NativeMethodInfoPtr_FindClass_Public_Static_IntPtr_String_0;

		// Token: 0x0400007C RID: 124
		private static readonly IntPtr NativeMethodInfoPtr_FromReflectedMethod_Public_Static_IntPtr_IntPtr_0;

		// Token: 0x0400007D RID: 125
		private static readonly IntPtr NativeMethodInfoPtr_ExceptionOccurred_Public_Static_IntPtr_0;

		// Token: 0x0400007E RID: 126
		private static readonly IntPtr NativeMethodInfoPtr_ExceptionClear_Public_Static_Void_0;

		// Token: 0x0400007F RID: 127
		private static readonly IntPtr NativeMethodInfoPtr_PushLocalFrame_Public_Static_Int32_Int32_0;

		// Token: 0x04000080 RID: 128
		private static readonly IntPtr NativeMethodInfoPtr_PopLocalFrame_Public_Static_IntPtr_IntPtr_0;

		// Token: 0x04000081 RID: 129
		private static readonly IntPtr NativeMethodInfoPtr_NewGlobalRef_Public_Static_IntPtr_IntPtr_0;

		// Token: 0x04000082 RID: 130
		private static readonly IntPtr NativeMethodInfoPtr_DeleteGlobalRef_Public_Static_Void_IntPtr_0;

		// Token: 0x04000083 RID: 131
		private static readonly IntPtr NativeMethodInfoPtr_NewWeakGlobalRef_Public_Static_IntPtr_IntPtr_0;

		// Token: 0x04000084 RID: 132
		private static readonly IntPtr NativeMethodInfoPtr_DeleteWeakGlobalRef_Public_Static_Void_IntPtr_0;

		// Token: 0x04000085 RID: 133
		private static readonly IntPtr NativeMethodInfoPtr_NewLocalRef_Public_Static_IntPtr_IntPtr_0;

		// Token: 0x04000086 RID: 134
		private static readonly IntPtr NativeMethodInfoPtr_DeleteLocalRef_Public_Static_Void_IntPtr_0;

		// Token: 0x04000087 RID: 135
		private static readonly IntPtr NativeMethodInfoPtr_NewObject_Public_Static_IntPtr_IntPtr_IntPtr_Il2CppStructArray_1_jvalue_0;

		// Token: 0x04000088 RID: 136
		private static readonly IntPtr NativeMethodInfoPtr_GetObjectClass_Public_Static_IntPtr_IntPtr_0;

		// Token: 0x04000089 RID: 137
		private static readonly IntPtr NativeMethodInfoPtr_GetMethodID_Public_Static_IntPtr_IntPtr_String_String_0;

		// Token: 0x0400008A RID: 138
		private static readonly IntPtr NativeMethodInfoPtr_GetFieldID_Public_Static_IntPtr_IntPtr_String_String_0;

		// Token: 0x0400008B RID: 139
		private static readonly IntPtr NativeMethodInfoPtr_GetStaticMethodID_Public_Static_IntPtr_IntPtr_String_String_0;

		// Token: 0x0400008C RID: 140
		private static readonly IntPtr NativeMethodInfoPtr_GetStaticFieldID_Public_Static_IntPtr_IntPtr_String_String_0;

		// Token: 0x0400008D RID: 141
		private static readonly IntPtr NativeMethodInfoPtr_NewString_Public_Static_IntPtr_String_0;

		// Token: 0x0400008E RID: 142
		private static readonly IntPtr NativeMethodInfoPtr_NewStringFromStr_Private_Static_IntPtr_String_0;

		// Token: 0x0400008F RID: 143
		private static readonly IntPtr NativeMethodInfoPtr_GetStringChars_Public_Static_String_IntPtr_0;

		// Token: 0x04000090 RID: 144
		private static readonly IntPtr NativeMethodInfoPtr_CallStringMethod_Public_Static_String_IntPtr_IntPtr_Il2CppStructArray_1_jvalue_0;

		// Token: 0x04000091 RID: 145
		private static readonly IntPtr NativeMethodInfoPtr_CallObjectMethod_Public_Static_IntPtr_IntPtr_IntPtr_Il2CppStructArray_1_jvalue_0;

		// Token: 0x04000092 RID: 146
		private static readonly IntPtr NativeMethodInfoPtr_CallIntMethod_Public_Static_Int32_IntPtr_IntPtr_Il2CppStructArray_1_jvalue_0;

		// Token: 0x04000093 RID: 147
		private static readonly IntPtr NativeMethodInfoPtr_CallBooleanMethod_Public_Static_Boolean_IntPtr_IntPtr_Il2CppStructArray_1_jvalue_0;

		// Token: 0x04000094 RID: 148
		private static readonly IntPtr NativeMethodInfoPtr_CallShortMethod_Public_Static_Int16_IntPtr_IntPtr_Il2CppStructArray_1_jvalue_0;

		// Token: 0x04000095 RID: 149
		private static readonly IntPtr NativeMethodInfoPtr_CallSByteMethod_Public_Static_SByte_IntPtr_IntPtr_Il2CppStructArray_1_jvalue_0;

		// Token: 0x04000096 RID: 150
		private static readonly IntPtr NativeMethodInfoPtr_CallCharMethod_Public_Static_Char_IntPtr_IntPtr_Il2CppStructArray_1_jvalue_0;

		// Token: 0x04000097 RID: 151
		private static readonly IntPtr NativeMethodInfoPtr_CallFloatMethod_Public_Static_Single_IntPtr_IntPtr_Il2CppStructArray_1_jvalue_0;

		// Token: 0x04000098 RID: 152
		private static readonly IntPtr NativeMethodInfoPtr_CallDoubleMethod_Public_Static_Double_IntPtr_IntPtr_Il2CppStructArray_1_jvalue_0;

		// Token: 0x04000099 RID: 153
		private static readonly IntPtr NativeMethodInfoPtr_CallLongMethod_Public_Static_Int64_IntPtr_IntPtr_Il2CppStructArray_1_jvalue_0;

		// Token: 0x0400009A RID: 154
		private static readonly IntPtr NativeMethodInfoPtr_CallVoidMethod_Public_Static_Void_IntPtr_IntPtr_Il2CppStructArray_1_jvalue_0;

		// Token: 0x0400009B RID: 155
		private static readonly IntPtr NativeMethodInfoPtr_CallStaticStringMethod_Public_Static_String_IntPtr_IntPtr_Il2CppStructArray_1_jvalue_0;

		// Token: 0x0400009C RID: 156
		private static readonly IntPtr NativeMethodInfoPtr_CallStaticObjectMethod_Public_Static_IntPtr_IntPtr_IntPtr_Il2CppStructArray_1_jvalue_0;

		// Token: 0x0400009D RID: 157
		private static readonly IntPtr NativeMethodInfoPtr_CallStaticIntMethod_Public_Static_Int32_IntPtr_IntPtr_Il2CppStructArray_1_jvalue_0;

		// Token: 0x0400009E RID: 158
		private static readonly IntPtr NativeMethodInfoPtr_CallStaticBooleanMethod_Public_Static_Boolean_IntPtr_IntPtr_Il2CppStructArray_1_jvalue_0;

		// Token: 0x0400009F RID: 159
		private static readonly IntPtr NativeMethodInfoPtr_CallStaticShortMethod_Public_Static_Int16_IntPtr_IntPtr_Il2CppStructArray_1_jvalue_0;

		// Token: 0x040000A0 RID: 160
		private static readonly IntPtr NativeMethodInfoPtr_CallStaticSByteMethod_Public_Static_SByte_IntPtr_IntPtr_Il2CppStructArray_1_jvalue_0;

		// Token: 0x040000A1 RID: 161
		private static readonly IntPtr NativeMethodInfoPtr_CallStaticCharMethod_Public_Static_Char_IntPtr_IntPtr_Il2CppStructArray_1_jvalue_0;

		// Token: 0x040000A2 RID: 162
		private static readonly IntPtr NativeMethodInfoPtr_CallStaticFloatMethod_Public_Static_Single_IntPtr_IntPtr_Il2CppStructArray_1_jvalue_0;

		// Token: 0x040000A3 RID: 163
		private static readonly IntPtr NativeMethodInfoPtr_CallStaticDoubleMethod_Public_Static_Double_IntPtr_IntPtr_Il2CppStructArray_1_jvalue_0;

		// Token: 0x040000A4 RID: 164
		private static readonly IntPtr NativeMethodInfoPtr_CallStaticLongMethod_Public_Static_Int64_IntPtr_IntPtr_Il2CppStructArray_1_jvalue_0;

		// Token: 0x040000A5 RID: 165
		private static readonly IntPtr NativeMethodInfoPtr_CallStaticVoidMethod_Public_Static_Void_IntPtr_IntPtr_Il2CppStructArray_1_jvalue_0;

		// Token: 0x040000A6 RID: 166
		private static readonly IntPtr NativeMethodInfoPtr_GetStaticStringField_Public_Static_String_IntPtr_IntPtr_0;

		// Token: 0x040000A7 RID: 167
		private static readonly IntPtr NativeMethodInfoPtr_GetStaticObjectField_Public_Static_IntPtr_IntPtr_IntPtr_0;

		// Token: 0x040000A8 RID: 168
		private static readonly IntPtr NativeMethodInfoPtr_GetStaticBooleanField_Public_Static_Boolean_IntPtr_IntPtr_0;

		// Token: 0x040000A9 RID: 169
		private static readonly IntPtr NativeMethodInfoPtr_GetStaticSByteField_Public_Static_SByte_IntPtr_IntPtr_0;

		// Token: 0x040000AA RID: 170
		private static readonly IntPtr NativeMethodInfoPtr_GetStaticCharField_Public_Static_Char_IntPtr_IntPtr_0;

		// Token: 0x040000AB RID: 171
		private static readonly IntPtr NativeMethodInfoPtr_GetStaticShortField_Public_Static_Int16_IntPtr_IntPtr_0;

		// Token: 0x040000AC RID: 172
		private static readonly IntPtr NativeMethodInfoPtr_GetStaticIntField_Public_Static_Int32_IntPtr_IntPtr_0;

		// Token: 0x040000AD RID: 173
		private static readonly IntPtr NativeMethodInfoPtr_GetStaticLongField_Public_Static_Int64_IntPtr_IntPtr_0;

		// Token: 0x040000AE RID: 174
		private static readonly IntPtr NativeMethodInfoPtr_GetStaticFloatField_Public_Static_Single_IntPtr_IntPtr_0;

		// Token: 0x040000AF RID: 175
		private static readonly IntPtr NativeMethodInfoPtr_GetStaticDoubleField_Public_Static_Double_IntPtr_IntPtr_0;

		// Token: 0x040000B0 RID: 176
		private static readonly IntPtr NativeMethodInfoPtr_ToBooleanArray_Public_Static_IntPtr_Il2CppStructArray_1_Boolean_0;

		// Token: 0x040000B1 RID: 177
		private static readonly IntPtr NativeMethodInfoPtr_ToByteArray_Public_Static_IntPtr_Il2CppStructArray_1_Byte_0;

		// Token: 0x040000B2 RID: 178
		private static readonly IntPtr NativeMethodInfoPtr_ToSByteArray_Public_Static_IntPtr_Il2CppStructArray_1_SByte_0;

		// Token: 0x040000B3 RID: 179
		private static readonly IntPtr NativeMethodInfoPtr_ToCharArray_Public_Static_IntPtr_Il2CppStructArray_1_Char_0;

		// Token: 0x040000B4 RID: 180
		private static readonly IntPtr NativeMethodInfoPtr_ToShortArray_Public_Static_IntPtr_Il2CppStructArray_1_Int16_0;

		// Token: 0x040000B5 RID: 181
		private static readonly IntPtr NativeMethodInfoPtr_ToIntArray_Public_Static_IntPtr_Il2CppStructArray_1_Int32_0;

		// Token: 0x040000B6 RID: 182
		private static readonly IntPtr NativeMethodInfoPtr_ToLongArray_Public_Static_IntPtr_Il2CppStructArray_1_Int64_0;

		// Token: 0x040000B7 RID: 183
		private static readonly IntPtr NativeMethodInfoPtr_ToFloatArray_Public_Static_IntPtr_Il2CppStructArray_1_Single_0;

		// Token: 0x040000B8 RID: 184
		private static readonly IntPtr NativeMethodInfoPtr_ToDoubleArray_Public_Static_IntPtr_Il2CppStructArray_1_Double_0;

		// Token: 0x040000B9 RID: 185
		private static readonly IntPtr NativeMethodInfoPtr_ToObjectArray_Public_Static_IntPtr_Il2CppStructArray_1_IntPtr_IntPtr_0;

		// Token: 0x040000BA RID: 186
		private static readonly IntPtr NativeMethodInfoPtr_FromBooleanArray_Public_Static_Il2CppStructArray_1_Boolean_IntPtr_0;

		// Token: 0x040000BB RID: 187
		private static readonly IntPtr NativeMethodInfoPtr_FromByteArray_Public_Static_Il2CppStructArray_1_Byte_IntPtr_0;

		// Token: 0x040000BC RID: 188
		private static readonly IntPtr NativeMethodInfoPtr_FromSByteArray_Public_Static_Il2CppStructArray_1_SByte_IntPtr_0;

		// Token: 0x040000BD RID: 189
		private static readonly IntPtr NativeMethodInfoPtr_FromCharArray_Public_Static_Il2CppStructArray_1_Char_IntPtr_0;

		// Token: 0x040000BE RID: 190
		private static readonly IntPtr NativeMethodInfoPtr_FromShortArray_Public_Static_Il2CppStructArray_1_Int16_IntPtr_0;

		// Token: 0x040000BF RID: 191
		private static readonly IntPtr NativeMethodInfoPtr_FromIntArray_Public_Static_Il2CppStructArray_1_Int32_IntPtr_0;

		// Token: 0x040000C0 RID: 192
		private static readonly IntPtr NativeMethodInfoPtr_FromLongArray_Public_Static_Il2CppStructArray_1_Int64_IntPtr_0;

		// Token: 0x040000C1 RID: 193
		private static readonly IntPtr NativeMethodInfoPtr_FromFloatArray_Public_Static_Il2CppStructArray_1_Single_IntPtr_0;

		// Token: 0x040000C2 RID: 194
		private static readonly IntPtr NativeMethodInfoPtr_FromDoubleArray_Public_Static_Il2CppStructArray_1_Double_IntPtr_0;

		// Token: 0x040000C3 RID: 195
		private static readonly IntPtr NativeMethodInfoPtr_GetArrayLength_Public_Static_Int32_IntPtr_0;

		// Token: 0x040000C4 RID: 196
		private static readonly IntPtr NativeMethodInfoPtr_NewObjectArray_Public_Static_IntPtr_Int32_IntPtr_IntPtr_0;

		// Token: 0x040000C5 RID: 197
		private static readonly IntPtr NativeMethodInfoPtr_GetObjectArrayElement_Public_Static_IntPtr_IntPtr_Int32_0;

		// Token: 0x040000C6 RID: 198
		private static readonly IntPtr NativeMethodInfoPtr_SetObjectArrayElement_Public_Static_Void_IntPtr_Int32_IntPtr_0;

		// Token: 0x040000C7 RID: 199
		private static readonly AndroidJNI.AttachCurrentThreadDelegate AttachCurrentThreadDelegateField;

		// Token: 0x040000C8 RID: 200
		private static readonly AndroidJNI.DetachCurrentThreadDelegate DetachCurrentThreadDelegateField;

		// Token: 0x040000C9 RID: 201
		private static readonly AndroidJNI.GetVersionDelegate GetVersionDelegateField;

		// Token: 0x040000CA RID: 202
		private static readonly AndroidJNI.FromReflectedFieldDelegate FromReflectedFieldDelegateField;

		// Token: 0x040000CB RID: 203
		private static readonly AndroidJNI.ToReflectedMethodDelegate ToReflectedMethodDelegateField;

		// Token: 0x040000CC RID: 204
		private static readonly AndroidJNI.ToReflectedFieldDelegate ToReflectedFieldDelegateField;

		// Token: 0x040000CD RID: 205
		private static readonly AndroidJNI.GetSuperclassDelegate GetSuperclassDelegateField;

		// Token: 0x040000CE RID: 206
		private static readonly AndroidJNI.IsAssignableFromDelegate IsAssignableFromDelegateField;

		// Token: 0x040000CF RID: 207
		private static readonly AndroidJNI.ThrowDelegate ThrowDelegateField;

		// Token: 0x040000D0 RID: 208
		private static readonly AndroidJNI.ThrowNewDelegate ThrowNewDelegateField;

		// Token: 0x040000D1 RID: 209
		private static readonly AndroidJNI.ExceptionDescribeDelegate ExceptionDescribeDelegateField;

		// Token: 0x040000D2 RID: 210
		private static readonly AndroidJNI.FatalErrorDelegate FatalErrorDelegateField;

		// Token: 0x040000D3 RID: 211
		private static readonly AndroidJNI.IsSameObjectDelegate IsSameObjectDelegateField;

		// Token: 0x040000D4 RID: 212
		private static readonly AndroidJNI.EnsureLocalCapacityDelegate EnsureLocalCapacityDelegateField;

		// Token: 0x040000D5 RID: 213
		private static readonly AndroidJNI.AllocObjectDelegate AllocObjectDelegateField;

		// Token: 0x040000D6 RID: 214
		private static readonly AndroidJNI.IsInstanceOfDelegate IsInstanceOfDelegateField;

		// Token: 0x040000D7 RID: 215
		private static readonly AndroidJNI.NewStringDelegate NewStringDelegateField;

		// Token: 0x040000D8 RID: 216
		private static readonly AndroidJNI.NewStringUTFDelegate NewStringUTFDelegateField;

		// Token: 0x040000D9 RID: 217
		private static readonly AndroidJNI.GetStringLengthDelegate GetStringLengthDelegateField;

		// Token: 0x040000DA RID: 218
		private static readonly AndroidJNI.GetStringUTFLengthDelegate GetStringUTFLengthDelegateField;

		// Token: 0x040000DB RID: 219
		private static readonly AndroidJNI.GetStringUTFCharsDelegate GetStringUTFCharsDelegateField;

		// Token: 0x040000DC RID: 220
		private static readonly AndroidJNI.GetStringFieldDelegate GetStringFieldDelegateField;

		// Token: 0x040000DD RID: 221
		private static readonly AndroidJNI.GetObjectFieldDelegate GetObjectFieldDelegateField;

		// Token: 0x040000DE RID: 222
		private static readonly AndroidJNI.GetBooleanFieldDelegate GetBooleanFieldDelegateField;

		// Token: 0x040000DF RID: 223
		private static readonly AndroidJNI.GetSByteFieldDelegate GetSByteFieldDelegateField;

		// Token: 0x040000E0 RID: 224
		private static readonly AndroidJNI.GetCharFieldDelegate GetCharFieldDelegateField;

		// Token: 0x040000E1 RID: 225
		private static readonly AndroidJNI.GetShortFieldDelegate GetShortFieldDelegateField;

		// Token: 0x040000E2 RID: 226
		private static readonly AndroidJNI.GetIntFieldDelegate GetIntFieldDelegateField;

		// Token: 0x040000E3 RID: 227
		private static readonly AndroidJNI.GetLongFieldDelegate GetLongFieldDelegateField;

		// Token: 0x040000E4 RID: 228
		private static readonly AndroidJNI.GetFloatFieldDelegate GetFloatFieldDelegateField;

		// Token: 0x040000E5 RID: 229
		private static readonly AndroidJNI.GetDoubleFieldDelegate GetDoubleFieldDelegateField;

		// Token: 0x040000E6 RID: 230
		private static readonly AndroidJNI.SetStringFieldDelegate SetStringFieldDelegateField;

		// Token: 0x040000E7 RID: 231
		private static readonly AndroidJNI.SetObjectFieldDelegate SetObjectFieldDelegateField;

		// Token: 0x040000E8 RID: 232
		private static readonly AndroidJNI.SetBooleanFieldDelegate SetBooleanFieldDelegateField;

		// Token: 0x040000E9 RID: 233
		private static readonly AndroidJNI.SetSByteFieldDelegate SetSByteFieldDelegateField;

		// Token: 0x040000EA RID: 234
		private static readonly AndroidJNI.SetCharFieldDelegate SetCharFieldDelegateField;

		// Token: 0x040000EB RID: 235
		private static readonly AndroidJNI.SetShortFieldDelegate SetShortFieldDelegateField;

		// Token: 0x040000EC RID: 236
		private static readonly AndroidJNI.SetIntFieldDelegate SetIntFieldDelegateField;

		// Token: 0x040000ED RID: 237
		private static readonly AndroidJNI.SetLongFieldDelegate SetLongFieldDelegateField;

		// Token: 0x040000EE RID: 238
		private static readonly AndroidJNI.SetFloatFieldDelegate SetFloatFieldDelegateField;

		// Token: 0x040000EF RID: 239
		private static readonly AndroidJNI.SetDoubleFieldDelegate SetDoubleFieldDelegateField;

		// Token: 0x040000F0 RID: 240
		private static readonly AndroidJNI.SetStaticStringFieldDelegate SetStaticStringFieldDelegateField;

		// Token: 0x040000F1 RID: 241
		private static readonly AndroidJNI.SetStaticObjectFieldDelegate SetStaticObjectFieldDelegateField;

		// Token: 0x040000F2 RID: 242
		private static readonly AndroidJNI.SetStaticBooleanFieldDelegate SetStaticBooleanFieldDelegateField;

		// Token: 0x040000F3 RID: 243
		private static readonly AndroidJNI.SetStaticSByteFieldDelegate SetStaticSByteFieldDelegateField;

		// Token: 0x040000F4 RID: 244
		private static readonly AndroidJNI.SetStaticCharFieldDelegate SetStaticCharFieldDelegateField;

		// Token: 0x040000F5 RID: 245
		private static readonly AndroidJNI.SetStaticShortFieldDelegate SetStaticShortFieldDelegateField;

		// Token: 0x040000F6 RID: 246
		private static readonly AndroidJNI.SetStaticIntFieldDelegate SetStaticIntFieldDelegateField;

		// Token: 0x040000F7 RID: 247
		private static readonly AndroidJNI.SetStaticLongFieldDelegate SetStaticLongFieldDelegateField;

		// Token: 0x040000F8 RID: 248
		private static readonly AndroidJNI.SetStaticFloatFieldDelegate SetStaticFloatFieldDelegateField;

		// Token: 0x040000F9 RID: 249
		private static readonly AndroidJNI.SetStaticDoubleFieldDelegate SetStaticDoubleFieldDelegateField;

		// Token: 0x040000FA RID: 250
		private static readonly AndroidJNI.FromObjectArrayDelegate FromObjectArrayDelegateField;

		// Token: 0x040000FB RID: 251
		private static readonly AndroidJNI.NewBooleanArrayDelegate NewBooleanArrayDelegateField;

		// Token: 0x040000FC RID: 252
		private static readonly AndroidJNI.NewSByteArrayDelegate NewSByteArrayDelegateField;

		// Token: 0x040000FD RID: 253
		private static readonly AndroidJNI.NewCharArrayDelegate NewCharArrayDelegateField;

		// Token: 0x040000FE RID: 254
		private static readonly AndroidJNI.NewShortArrayDelegate NewShortArrayDelegateField;

		// Token: 0x040000FF RID: 255
		private static readonly AndroidJNI.NewIntArrayDelegate NewIntArrayDelegateField;

		// Token: 0x04000100 RID: 256
		private static readonly AndroidJNI.NewLongArrayDelegate NewLongArrayDelegateField;

		// Token: 0x04000101 RID: 257
		private static readonly AndroidJNI.NewFloatArrayDelegate NewFloatArrayDelegateField;

		// Token: 0x04000102 RID: 258
		private static readonly AndroidJNI.NewDoubleArrayDelegate NewDoubleArrayDelegateField;

		// Token: 0x04000103 RID: 259
		private static readonly AndroidJNI.GetBooleanArrayElementDelegate GetBooleanArrayElementDelegateField;

		// Token: 0x04000104 RID: 260
		private static readonly AndroidJNI.GetSByteArrayElementDelegate GetSByteArrayElementDelegateField;

		// Token: 0x04000105 RID: 261
		private static readonly AndroidJNI.GetCharArrayElementDelegate GetCharArrayElementDelegateField;

		// Token: 0x04000106 RID: 262
		private static readonly AndroidJNI.GetShortArrayElementDelegate GetShortArrayElementDelegateField;

		// Token: 0x04000107 RID: 263
		private static readonly AndroidJNI.GetIntArrayElementDelegate GetIntArrayElementDelegateField;

		// Token: 0x04000108 RID: 264
		private static readonly AndroidJNI.GetLongArrayElementDelegate GetLongArrayElementDelegateField;

		// Token: 0x04000109 RID: 265
		private static readonly AndroidJNI.GetFloatArrayElementDelegate GetFloatArrayElementDelegateField;

		// Token: 0x0400010A RID: 266
		private static readonly AndroidJNI.GetDoubleArrayElementDelegate GetDoubleArrayElementDelegateField;

		// Token: 0x0400010B RID: 267
		private static readonly AndroidJNI.SetBooleanArrayElementDelegate SetBooleanArrayElementDelegateField;

		// Token: 0x0400010C RID: 268
		private static readonly AndroidJNI.SetSByteArrayElementDelegate SetSByteArrayElementDelegateField;

		// Token: 0x0400010D RID: 269
		private static readonly AndroidJNI.SetCharArrayElementDelegate SetCharArrayElementDelegateField;

		// Token: 0x0400010E RID: 270
		private static readonly AndroidJNI.SetShortArrayElementDelegate SetShortArrayElementDelegateField;

		// Token: 0x0400010F RID: 271
		private static readonly AndroidJNI.SetIntArrayElementDelegate SetIntArrayElementDelegateField;

		// Token: 0x04000110 RID: 272
		private static readonly AndroidJNI.SetLongArrayElementDelegate SetLongArrayElementDelegateField;

		// Token: 0x04000111 RID: 273
		private static readonly AndroidJNI.SetFloatArrayElementDelegate SetFloatArrayElementDelegateField;

		// Token: 0x04000112 RID: 274
		private static readonly AndroidJNI.SetDoubleArrayElementDelegate SetDoubleArrayElementDelegateField;

		// Token: 0x0200002A RID: 42
		// (Invoke) Token: 0x0600020D RID: 525
		private delegate int AttachCurrentThreadDelegate();

		// Token: 0x0200002B RID: 43
		// (Invoke) Token: 0x0600020F RID: 527
		private delegate int DetachCurrentThreadDelegate();

		// Token: 0x0200002C RID: 44
		// (Invoke) Token: 0x06000211 RID: 529
		private delegate int GetVersionDelegate();

		// Token: 0x0200002D RID: 45
		// (Invoke) Token: 0x06000213 RID: 531
		private delegate IntPtr FromReflectedFieldDelegate(IntPtr refField);

		// Token: 0x0200002E RID: 46
		// (Invoke) Token: 0x06000215 RID: 533
		private delegate IntPtr ToReflectedMethodDelegate(IntPtr clazz, IntPtr methodID, bool isStatic);

		// Token: 0x0200002F RID: 47
		// (Invoke) Token: 0x06000217 RID: 535
		private delegate IntPtr ToReflectedFieldDelegate(IntPtr clazz, IntPtr fieldID, bool isStatic);

		// Token: 0x02000030 RID: 48
		// (Invoke) Token: 0x06000219 RID: 537
		private delegate IntPtr GetSuperclassDelegate(IntPtr clazz);

		// Token: 0x02000031 RID: 49
		// (Invoke) Token: 0x0600021B RID: 539
		private delegate bool IsAssignableFromDelegate(IntPtr clazz1, IntPtr clazz2);

		// Token: 0x02000032 RID: 50
		// (Invoke) Token: 0x0600021D RID: 541
		private delegate int ThrowDelegate(IntPtr obj);

		// Token: 0x02000033 RID: 51
		// (Invoke) Token: 0x0600021F RID: 543
		private delegate int ThrowNewDelegate(IntPtr clazz, IntPtr message);

		// Token: 0x02000034 RID: 52
		// (Invoke) Token: 0x06000221 RID: 545
		private delegate void ExceptionDescribeDelegate();

		// Token: 0x02000035 RID: 53
		// (Invoke) Token: 0x06000223 RID: 547
		private delegate void FatalErrorDelegate(IntPtr message);

		// Token: 0x02000036 RID: 54
		// (Invoke) Token: 0x06000225 RID: 549
		private delegate bool IsSameObjectDelegate(IntPtr obj1, IntPtr obj2);

		// Token: 0x02000037 RID: 55
		// (Invoke) Token: 0x06000227 RID: 551
		private delegate int EnsureLocalCapacityDelegate(int capacity);

		// Token: 0x02000038 RID: 56
		// (Invoke) Token: 0x06000229 RID: 553
		private delegate IntPtr AllocObjectDelegate(IntPtr clazz);

		// Token: 0x02000039 RID: 57
		// (Invoke) Token: 0x0600022B RID: 555
		private delegate bool IsInstanceOfDelegate(IntPtr obj, IntPtr clazz);

		// Token: 0x0200003A RID: 58
		// (Invoke) Token: 0x0600022D RID: 557
		private delegate IntPtr NewStringDelegate(IntPtr chars);

		// Token: 0x0200003B RID: 59
		// (Invoke) Token: 0x0600022F RID: 559
		private delegate IntPtr NewStringUTFDelegate(IntPtr bytes);

		// Token: 0x0200003C RID: 60
		// (Invoke) Token: 0x06000231 RID: 561
		private delegate int GetStringLengthDelegate(IntPtr str);

		// Token: 0x0200003D RID: 61
		// (Invoke) Token: 0x06000233 RID: 563
		private delegate int GetStringUTFLengthDelegate(IntPtr str);

		// Token: 0x0200003E RID: 62
		// (Invoke) Token: 0x06000235 RID: 565
		private delegate IntPtr GetStringUTFCharsDelegate(IntPtr str);

		// Token: 0x0200003F RID: 63
		// (Invoke) Token: 0x06000237 RID: 567
		private delegate IntPtr GetStringFieldDelegate(IntPtr obj, IntPtr fieldID);

		// Token: 0x02000040 RID: 64
		// (Invoke) Token: 0x06000239 RID: 569
		private delegate IntPtr GetObjectFieldDelegate(IntPtr obj, IntPtr fieldID);

		// Token: 0x02000041 RID: 65
		// (Invoke) Token: 0x0600023B RID: 571
		private delegate bool GetBooleanFieldDelegate(IntPtr obj, IntPtr fieldID);

		// Token: 0x02000042 RID: 66
		// (Invoke) Token: 0x0600023D RID: 573
		private delegate sbyte GetSByteFieldDelegate(IntPtr obj, IntPtr fieldID);

		// Token: 0x02000043 RID: 67
		// (Invoke) Token: 0x0600023F RID: 575
		private delegate char GetCharFieldDelegate(IntPtr obj, IntPtr fieldID);

		// Token: 0x02000044 RID: 68
		// (Invoke) Token: 0x06000241 RID: 577
		private delegate short GetShortFieldDelegate(IntPtr obj, IntPtr fieldID);

		// Token: 0x02000045 RID: 69
		// (Invoke) Token: 0x06000243 RID: 579
		private delegate int GetIntFieldDelegate(IntPtr obj, IntPtr fieldID);

		// Token: 0x02000046 RID: 70
		// (Invoke) Token: 0x06000245 RID: 581
		private delegate long GetLongFieldDelegate(IntPtr obj, IntPtr fieldID);

		// Token: 0x02000047 RID: 71
		// (Invoke) Token: 0x06000247 RID: 583
		private delegate float GetFloatFieldDelegate(IntPtr obj, IntPtr fieldID);

		// Token: 0x02000048 RID: 72
		// (Invoke) Token: 0x06000249 RID: 585
		private delegate double GetDoubleFieldDelegate(IntPtr obj, IntPtr fieldID);

		// Token: 0x02000049 RID: 73
		// (Invoke) Token: 0x0600024B RID: 587
		private delegate void SetStringFieldDelegate(IntPtr obj, IntPtr fieldID, IntPtr val);

		// Token: 0x0200004A RID: 74
		// (Invoke) Token: 0x0600024D RID: 589
		private delegate void SetObjectFieldDelegate(IntPtr obj, IntPtr fieldID, IntPtr val);

		// Token: 0x0200004B RID: 75
		// (Invoke) Token: 0x0600024F RID: 591
		private delegate void SetBooleanFieldDelegate(IntPtr obj, IntPtr fieldID, bool val);

		// Token: 0x0200004C RID: 76
		// (Invoke) Token: 0x06000251 RID: 593
		private delegate void SetSByteFieldDelegate(IntPtr obj, IntPtr fieldID, sbyte val);

		// Token: 0x0200004D RID: 77
		// (Invoke) Token: 0x06000253 RID: 595
		private delegate void SetCharFieldDelegate(IntPtr obj, IntPtr fieldID, char val);

		// Token: 0x0200004E RID: 78
		// (Invoke) Token: 0x06000255 RID: 597
		private delegate void SetShortFieldDelegate(IntPtr obj, IntPtr fieldID, short val);

		// Token: 0x0200004F RID: 79
		// (Invoke) Token: 0x06000257 RID: 599
		private delegate void SetIntFieldDelegate(IntPtr obj, IntPtr fieldID, int val);

		// Token: 0x02000050 RID: 80
		// (Invoke) Token: 0x06000259 RID: 601
		private delegate void SetLongFieldDelegate(IntPtr obj, IntPtr fieldID, long val);

		// Token: 0x02000051 RID: 81
		// (Invoke) Token: 0x0600025B RID: 603
		private delegate void SetFloatFieldDelegate(IntPtr obj, IntPtr fieldID, float val);

		// Token: 0x02000052 RID: 82
		// (Invoke) Token: 0x0600025D RID: 605
		private delegate void SetDoubleFieldDelegate(IntPtr obj, IntPtr fieldID, double val);

		// Token: 0x02000053 RID: 83
		// (Invoke) Token: 0x0600025F RID: 607
		private delegate void SetStaticStringFieldDelegate(IntPtr clazz, IntPtr fieldID, IntPtr val);

		// Token: 0x02000054 RID: 84
		// (Invoke) Token: 0x06000261 RID: 609
		private delegate void SetStaticObjectFieldDelegate(IntPtr clazz, IntPtr fieldID, IntPtr val);

		// Token: 0x02000055 RID: 85
		// (Invoke) Token: 0x06000263 RID: 611
		private delegate void SetStaticBooleanFieldDelegate(IntPtr clazz, IntPtr fieldID, bool val);

		// Token: 0x02000056 RID: 86
		// (Invoke) Token: 0x06000265 RID: 613
		private delegate void SetStaticSByteFieldDelegate(IntPtr clazz, IntPtr fieldID, sbyte val);

		// Token: 0x02000057 RID: 87
		// (Invoke) Token: 0x06000267 RID: 615
		private delegate void SetStaticCharFieldDelegate(IntPtr clazz, IntPtr fieldID, char val);

		// Token: 0x02000058 RID: 88
		// (Invoke) Token: 0x06000269 RID: 617
		private delegate void SetStaticShortFieldDelegate(IntPtr clazz, IntPtr fieldID, short val);

		// Token: 0x02000059 RID: 89
		// (Invoke) Token: 0x0600026B RID: 619
		private delegate void SetStaticIntFieldDelegate(IntPtr clazz, IntPtr fieldID, int val);

		// Token: 0x0200005A RID: 90
		// (Invoke) Token: 0x0600026D RID: 621
		private delegate void SetStaticLongFieldDelegate(IntPtr clazz, IntPtr fieldID, long val);

		// Token: 0x0200005B RID: 91
		// (Invoke) Token: 0x0600026F RID: 623
		private delegate void SetStaticFloatFieldDelegate(IntPtr clazz, IntPtr fieldID, float val);

		// Token: 0x0200005C RID: 92
		// (Invoke) Token: 0x06000271 RID: 625
		private delegate void SetStaticDoubleFieldDelegate(IntPtr clazz, IntPtr fieldID, double val);

		// Token: 0x0200005D RID: 93
		// (Invoke) Token: 0x06000273 RID: 627
		private delegate IntPtr FromObjectArrayDelegate(IntPtr array);

		// Token: 0x0200005E RID: 94
		// (Invoke) Token: 0x06000275 RID: 629
		private delegate IntPtr NewBooleanArrayDelegate(int size);

		// Token: 0x0200005F RID: 95
		// (Invoke) Token: 0x06000277 RID: 631
		private delegate IntPtr NewSByteArrayDelegate(int size);

		// Token: 0x02000060 RID: 96
		// (Invoke) Token: 0x06000279 RID: 633
		private delegate IntPtr NewCharArrayDelegate(int size);

		// Token: 0x02000061 RID: 97
		// (Invoke) Token: 0x0600027B RID: 635
		private delegate IntPtr NewShortArrayDelegate(int size);

		// Token: 0x02000062 RID: 98
		// (Invoke) Token: 0x0600027D RID: 637
		private delegate IntPtr NewIntArrayDelegate(int size);

		// Token: 0x02000063 RID: 99
		// (Invoke) Token: 0x0600027F RID: 639
		private delegate IntPtr NewLongArrayDelegate(int size);

		// Token: 0x02000064 RID: 100
		// (Invoke) Token: 0x06000281 RID: 641
		private delegate IntPtr NewFloatArrayDelegate(int size);

		// Token: 0x02000065 RID: 101
		// (Invoke) Token: 0x06000283 RID: 643
		private delegate IntPtr NewDoubleArrayDelegate(int size);

		// Token: 0x02000066 RID: 102
		// (Invoke) Token: 0x06000285 RID: 645
		private delegate bool GetBooleanArrayElementDelegate(IntPtr array, int index);

		// Token: 0x02000067 RID: 103
		// (Invoke) Token: 0x06000287 RID: 647
		private delegate sbyte GetSByteArrayElementDelegate(IntPtr array, int index);

		// Token: 0x02000068 RID: 104
		// (Invoke) Token: 0x06000289 RID: 649
		private delegate char GetCharArrayElementDelegate(IntPtr array, int index);

		// Token: 0x02000069 RID: 105
		// (Invoke) Token: 0x0600028B RID: 651
		private delegate short GetShortArrayElementDelegate(IntPtr array, int index);

		// Token: 0x0200006A RID: 106
		// (Invoke) Token: 0x0600028D RID: 653
		private delegate int GetIntArrayElementDelegate(IntPtr array, int index);

		// Token: 0x0200006B RID: 107
		// (Invoke) Token: 0x0600028F RID: 655
		private delegate long GetLongArrayElementDelegate(IntPtr array, int index);

		// Token: 0x0200006C RID: 108
		// (Invoke) Token: 0x06000291 RID: 657
		private delegate float GetFloatArrayElementDelegate(IntPtr array, int index);

		// Token: 0x0200006D RID: 109
		// (Invoke) Token: 0x06000293 RID: 659
		private delegate double GetDoubleArrayElementDelegate(IntPtr array, int index);

		// Token: 0x0200006E RID: 110
		// (Invoke) Token: 0x06000295 RID: 661
		private delegate void SetBooleanArrayElementDelegate(IntPtr array, int index, bool val);

		// Token: 0x0200006F RID: 111
		// (Invoke) Token: 0x06000297 RID: 663
		private delegate void SetSByteArrayElementDelegate(IntPtr array, int index, sbyte val);

		// Token: 0x02000070 RID: 112
		// (Invoke) Token: 0x06000299 RID: 665
		private delegate void SetCharArrayElementDelegate(IntPtr array, int index, char val);

		// Token: 0x02000071 RID: 113
		// (Invoke) Token: 0x0600029B RID: 667
		private delegate void SetShortArrayElementDelegate(IntPtr array, int index, short val);

		// Token: 0x02000072 RID: 114
		// (Invoke) Token: 0x0600029D RID: 669
		private delegate void SetIntArrayElementDelegate(IntPtr array, int index, int val);

		// Token: 0x02000073 RID: 115
		// (Invoke) Token: 0x0600029F RID: 671
		private delegate void SetLongArrayElementDelegate(IntPtr array, int index, long val);

		// Token: 0x02000074 RID: 116
		// (Invoke) Token: 0x060002A1 RID: 673
		private delegate void SetFloatArrayElementDelegate(IntPtr array, int index, float val);

		// Token: 0x02000075 RID: 117
		// (Invoke) Token: 0x060002A3 RID: 675
		private delegate void SetDoubleArrayElementDelegate(IntPtr array, int index, double val);
	}
}
