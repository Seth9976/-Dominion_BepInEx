using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

// Token: 0x020000C9 RID: 201
public class AN_SocialSharingProxy : Object
{
	// Token: 0x06000E77 RID: 3703 RVA: 0x0004A7DC File Offset: 0x000489DC
	// Note: this type is marked as 'beforefieldinit'.
	static AN_SocialSharingProxy()
	{
		Il2CppClassPointerStore<AN_SocialSharingProxy>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "AN_SocialSharingProxy");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AN_SocialSharingProxy>.NativeClassPtr);
		AN_SocialSharingProxy.NativeFieldInfoPtr_CLASS_NAME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AN_SocialSharingProxy>.NativeClassPtr, "CLASS_NAME");
		AN_SocialSharingProxy.NativeMethodInfoPtr_CallActivityFunction_Private_Static_Void_String_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_SocialSharingProxy>.NativeClassPtr, 100665120);
		AN_SocialSharingProxy.NativeMethodInfoPtr_GetLaunchDeepLinkId_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_SocialSharingProxy>.NativeClassPtr, 100665121);
		AN_SocialSharingProxy.NativeMethodInfoPtr_GooglePlusShare_Public_Static_Void_String_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_SocialSharingProxy>.NativeClassPtr, 100665122);
		AN_SocialSharingProxy.NativeMethodInfoPtr_ShareTwitterGif_Public_Static_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_SocialSharingProxy>.NativeClassPtr, 100665123);
		AN_SocialSharingProxy.NativeMethodInfoPtr_StartGooglePlusShareIntent_Public_Static_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_SocialSharingProxy>.NativeClassPtr, 100665124);
		AN_SocialSharingProxy.NativeMethodInfoPtr_StartVideoShareIntent_Public_Static_Void_String_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_SocialSharingProxy>.NativeClassPtr, 100665125);
		AN_SocialSharingProxy.NativeMethodInfoPtr_StartShareIntent_Public_Static_Void_String_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_SocialSharingProxy>.NativeClassPtr, 100665126);
		AN_SocialSharingProxy.NativeMethodInfoPtr_StartShareCollectionIntent_Public_Static_Void_String_String_String_String_String_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_SocialSharingProxy>.NativeClassPtr, 100665127);
		AN_SocialSharingProxy.NativeMethodInfoPtr_StartShareIntent_Public_Static_Void_String_String_String_String_String_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_SocialSharingProxy>.NativeClassPtr, 100665128);
		AN_SocialSharingProxy.NativeMethodInfoPtr_SendMailWithImages_Public_Static_Void_String_String_String_String_String_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_SocialSharingProxy>.NativeClassPtr, 100665129);
		AN_SocialSharingProxy.NativeMethodInfoPtr_SendMailWithImage_Public_Static_Void_String_String_String_String_String_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_SocialSharingProxy>.NativeClassPtr, 100665130);
		AN_SocialSharingProxy.NativeMethodInfoPtr_SendMail_Public_Static_Void_String_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_SocialSharingProxy>.NativeClassPtr, 100665131);
		AN_SocialSharingProxy.NativeMethodInfoPtr_InstagramPostImage_Public_Static_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_SocialSharingProxy>.NativeClassPtr, 100665132);
		AN_SocialSharingProxy.NativeMethodInfoPtr_SendTextMessage_Public_Static_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_SocialSharingProxy>.NativeClassPtr, 100665133);
		AN_SocialSharingProxy.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_SocialSharingProxy>.NativeClassPtr, 100665134);
	}

	// Token: 0x06000E78 RID: 3704 RVA: 0x0004A94C File Offset: 0x00048B4C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 178739, XrefRangeEnd = 178740, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void CallActivityFunction(string methodName, [Optional] Il2CppReferenceArray<Object> args)
	{
		if (args == null)
		{
			args = new Il2CppReferenceArray<Object>(0L);
		}
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(methodName);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_SocialSharingProxy.NativeMethodInfoPtr_CallActivityFunction_Private_Static_Void_String_Il2CppReferenceArray_1_Object_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000E79 RID: 3705 RVA: 0x0004A9A4 File Offset: 0x00048BA4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void GetLaunchDeepLinkId()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_SocialSharingProxy.NativeMethodInfoPtr_GetLaunchDeepLinkId_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000E7A RID: 3706 RVA: 0x0004A9CC File Offset: 0x00048BCC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 178740, XrefRangeEnd = 178747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void GooglePlusShare(string message, Il2CppStringArray images)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(images);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_SocialSharingProxy.NativeMethodInfoPtr_GooglePlusShare_Public_Static_Void_String_Il2CppStringArray_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000E7B RID: 3707 RVA: 0x0004AA14 File Offset: 0x00048C14
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 178754, RefRangeEnd = 178755, XrefRangeStart = 178747, XrefRangeEnd = 178754, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ShareTwitterGif(string path, string message)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(message);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_SocialSharingProxy.NativeMethodInfoPtr_ShareTwitterGif_Public_Static_Void_String_String_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000E7C RID: 3708 RVA: 0x0004AA5C File Offset: 0x00048C5C
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 178762, RefRangeEnd = 178763, XrefRangeStart = 178755, XrefRangeEnd = 178762, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void StartGooglePlusShareIntent(string text, string media)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(media);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_SocialSharingProxy.NativeMethodInfoPtr_StartGooglePlusShareIntent_Public_Static_Void_String_String_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000E7D RID: 3709 RVA: 0x0004AAA4 File Offset: 0x00048CA4
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 178772, RefRangeEnd = 178773, XrefRangeStart = 178763, XrefRangeEnd = 178772, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void StartVideoShareIntent(string videoFilePath, string message, string subject, string caption)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(videoFilePath);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(message);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(subject);
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(caption);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_SocialSharingProxy.NativeMethodInfoPtr_StartVideoShareIntent_Public_Static_Void_String_String_String_String_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000E7E RID: 3710 RVA: 0x0004AB10 File Offset: 0x00048D10
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 178782, RefRangeEnd = 178783, XrefRangeStart = 178773, XrefRangeEnd = 178782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void StartShareIntent(string caption, string message, string subject, string filters)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(caption);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(message);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(subject);
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(filters);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_SocialSharingProxy.NativeMethodInfoPtr_StartShareIntent_Public_Static_Void_String_String_String_String_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000E7F RID: 3711 RVA: 0x0004AB7C File Offset: 0x00048D7C
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 178801, RefRangeEnd = 178802, XrefRangeStart = 178783, XrefRangeEnd = 178801, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void StartShareCollectionIntent(string caption, string message, string subject, string collection, string filters, int format, bool saveImageToGallery = false)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(caption);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(message);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(subject);
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(collection);
		ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(filters);
		ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref format;
		ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref saveImageToGallery;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_SocialSharingProxy.NativeMethodInfoPtr_StartShareCollectionIntent_Public_Static_Void_String_String_String_String_String_Int32_Boolean_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000E80 RID: 3712 RVA: 0x0004AC18 File Offset: 0x00048E18
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 178820, RefRangeEnd = 178822, XrefRangeStart = 178802, XrefRangeEnd = 178820, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void StartShareIntent(string caption, string message, string subject, string media, string filters, int format, bool saveImageToGallery = false)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(caption);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(message);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(subject);
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(media);
		ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(filters);
		ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref format;
		ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref saveImageToGallery;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_SocialSharingProxy.NativeMethodInfoPtr_StartShareIntent_Public_Static_Void_String_String_String_String_String_Int32_Boolean_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000E81 RID: 3713 RVA: 0x0004ACB4 File Offset: 0x00048EB4
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 178840, RefRangeEnd = 178841, XrefRangeStart = 178822, XrefRangeEnd = 178840, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SendMailWithImages(string caption, string message, string subject, string email, string images, int format, bool saveImageToGallery = false)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(caption);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(message);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(subject);
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(email);
		ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(images);
		ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref format;
		ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref saveImageToGallery;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_SocialSharingProxy.NativeMethodInfoPtr_SendMailWithImages_Public_Static_Void_String_String_String_String_String_Int32_Boolean_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000E82 RID: 3714 RVA: 0x0004AD50 File Offset: 0x00048F50
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 178859, RefRangeEnd = 178860, XrefRangeStart = 178841, XrefRangeEnd = 178859, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SendMailWithImage(string caption, string message, string subject, string email, string media, int format, bool saveImageToGallery = false)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(caption);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(message);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(subject);
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(email);
		ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(media);
		ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref format;
		ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref saveImageToGallery;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_SocialSharingProxy.NativeMethodInfoPtr_SendMailWithImage_Public_Static_Void_String_String_String_String_String_Int32_Boolean_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000E83 RID: 3715 RVA: 0x0004ADEC File Offset: 0x00048FEC
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 178869, RefRangeEnd = 178870, XrefRangeStart = 178860, XrefRangeEnd = 178869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SendMail(string caption, string message, string subject, string email)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(caption);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(message);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(subject);
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(email);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_SocialSharingProxy.NativeMethodInfoPtr_SendMail_Public_Static_Void_String_String_String_String_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000E84 RID: 3716 RVA: 0x0004AE58 File Offset: 0x00049058
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 178877, RefRangeEnd = 178879, XrefRangeStart = 178870, XrefRangeEnd = 178877, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InstagramPostImage(string data, string cpation)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(data);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(cpation);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_SocialSharingProxy.NativeMethodInfoPtr_InstagramPostImage_Public_Static_Void_String_String_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000E85 RID: 3717 RVA: 0x0004AEA0 File Offset: 0x000490A0
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 178886, RefRangeEnd = 178887, XrefRangeStart = 178879, XrefRangeEnd = 178886, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SendTextMessage(string message, string recepients)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(recepients);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_SocialSharingProxy.NativeMethodInfoPtr_SendTextMessage_Public_Static_Void_String_String_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000E86 RID: 3718 RVA: 0x0004AEE8 File Offset: 0x000490E8
	[CallerCount(817)]
	[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AN_SocialSharingProxy()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AN_SocialSharingProxy>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_SocialSharingProxy.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000E87 RID: 3719 RVA: 0x0000778E File Offset: 0x0000598E
	public static void CallActivityFunction(string methodName, params Object[] args)
	{
		AN_SocialSharingProxy.CallActivityFunction(methodName, new Il2CppReferenceArray<Object>(args));
	}

	// Token: 0x06000E88 RID: 3720 RVA: 0x0000779C File Offset: 0x0000599C
	public AN_SocialSharingProxy(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x1700043E RID: 1086
	// (get) Token: 0x06000E89 RID: 3721 RVA: 0x0004AF24 File Offset: 0x00049124
	// (set) Token: 0x06000E8A RID: 3722 RVA: 0x000077A5 File Offset: 0x000059A5
	public unsafe static string CLASS_NAME
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(AN_SocialSharingProxy.NativeFieldInfoPtr_CLASS_NAME, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AN_SocialSharingProxy.NativeFieldInfoPtr_CLASS_NAME, IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x04000B3C RID: 2876
	private static readonly IntPtr NativeFieldInfoPtr_CLASS_NAME;

	// Token: 0x04000B3D RID: 2877
	private static readonly IntPtr NativeMethodInfoPtr_CallActivityFunction_Private_Static_Void_String_Il2CppReferenceArray_1_Object_0;

	// Token: 0x04000B3E RID: 2878
	private static readonly IntPtr NativeMethodInfoPtr_GetLaunchDeepLinkId_Public_Static_Void_0;

	// Token: 0x04000B3F RID: 2879
	private static readonly IntPtr NativeMethodInfoPtr_GooglePlusShare_Public_Static_Void_String_Il2CppStringArray_0;

	// Token: 0x04000B40 RID: 2880
	private static readonly IntPtr NativeMethodInfoPtr_ShareTwitterGif_Public_Static_Void_String_String_0;

	// Token: 0x04000B41 RID: 2881
	private static readonly IntPtr NativeMethodInfoPtr_StartGooglePlusShareIntent_Public_Static_Void_String_String_0;

	// Token: 0x04000B42 RID: 2882
	private static readonly IntPtr NativeMethodInfoPtr_StartVideoShareIntent_Public_Static_Void_String_String_String_String_0;

	// Token: 0x04000B43 RID: 2883
	private static readonly IntPtr NativeMethodInfoPtr_StartShareIntent_Public_Static_Void_String_String_String_String_0;

	// Token: 0x04000B44 RID: 2884
	private static readonly IntPtr NativeMethodInfoPtr_StartShareCollectionIntent_Public_Static_Void_String_String_String_String_String_Int32_Boolean_0;

	// Token: 0x04000B45 RID: 2885
	private static readonly IntPtr NativeMethodInfoPtr_StartShareIntent_Public_Static_Void_String_String_String_String_String_Int32_Boolean_0;

	// Token: 0x04000B46 RID: 2886
	private static readonly IntPtr NativeMethodInfoPtr_SendMailWithImages_Public_Static_Void_String_String_String_String_String_Int32_Boolean_0;

	// Token: 0x04000B47 RID: 2887
	private static readonly IntPtr NativeMethodInfoPtr_SendMailWithImage_Public_Static_Void_String_String_String_String_String_Int32_Boolean_0;

	// Token: 0x04000B48 RID: 2888
	private static readonly IntPtr NativeMethodInfoPtr_SendMail_Public_Static_Void_String_String_String_String_0;

	// Token: 0x04000B49 RID: 2889
	private static readonly IntPtr NativeMethodInfoPtr_InstagramPostImage_Public_Static_Void_String_String_0;

	// Token: 0x04000B4A RID: 2890
	private static readonly IntPtr NativeMethodInfoPtr_SendTextMessage_Public_Static_Void_String_String_0;

	// Token: 0x04000B4B RID: 2891
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
