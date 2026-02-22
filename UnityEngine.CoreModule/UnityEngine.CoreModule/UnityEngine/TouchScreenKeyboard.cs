using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x020000D9 RID: 217
	public class TouchScreenKeyboard : Object
	{
		// Token: 0x060012D6 RID: 4822 RVA: 0x00049300 File Offset: 0x00047500
		// Note: this type is marked as 'beforefieldinit'.
		static TouchScreenKeyboard()
		{
			Il2CppClassPointerStore<TouchScreenKeyboard>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "TouchScreenKeyboard");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TouchScreenKeyboard>.NativeClassPtr);
			TouchScreenKeyboard.NativeFieldInfoPtr_m_Ptr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchScreenKeyboard>.NativeClassPtr, "m_Ptr");
			TouchScreenKeyboard.NativeMethodInfoPtr_Internal_Destroy_Private_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchScreenKeyboard>.NativeClassPtr, 100664573);
			TouchScreenKeyboard.NativeMethodInfoPtr_Destroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchScreenKeyboard>.NativeClassPtr, 100664574);
			TouchScreenKeyboard.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchScreenKeyboard>.NativeClassPtr, 100664575);
			TouchScreenKeyboard.NativeMethodInfoPtr__ctor_Public_Void_String_TouchScreenKeyboardType_Boolean_Boolean_Boolean_Boolean_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchScreenKeyboard>.NativeClassPtr, 100664576);
			TouchScreenKeyboard.NativeMethodInfoPtr_TouchScreenKeyboard_InternalConstructorHelper_Private_Static_IntPtr_byref_TouchScreenKeyboard_InternalConstructorHelperArguments_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchScreenKeyboard>.NativeClassPtr, 100664577);
			TouchScreenKeyboard.NativeMethodInfoPtr_get_isSupported_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchScreenKeyboard>.NativeClassPtr, 100664578);
			TouchScreenKeyboard.NativeMethodInfoPtr_get_isInPlaceEditingAllowed_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchScreenKeyboard>.NativeClassPtr, 100664579);
			TouchScreenKeyboard.NativeMethodInfoPtr_Open_Public_Static_TouchScreenKeyboard_String_TouchScreenKeyboardType_Boolean_Boolean_Boolean_Boolean_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchScreenKeyboard>.NativeClassPtr, 100664580);
			TouchScreenKeyboard.NativeMethodInfoPtr_get_text_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchScreenKeyboard>.NativeClassPtr, 100664581);
			TouchScreenKeyboard.NativeMethodInfoPtr_set_text_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchScreenKeyboard>.NativeClassPtr, 100664582);
			TouchScreenKeyboard.NativeMethodInfoPtr_set_hideInput_Public_Static_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchScreenKeyboard>.NativeClassPtr, 100664583);
			TouchScreenKeyboard.NativeMethodInfoPtr_get_active_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchScreenKeyboard>.NativeClassPtr, 100664584);
			TouchScreenKeyboard.NativeMethodInfoPtr_set_active_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchScreenKeyboard>.NativeClassPtr, 100664585);
			TouchScreenKeyboard.NativeMethodInfoPtr_get_status_Public_get_Status_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchScreenKeyboard>.NativeClassPtr, 100664586);
			TouchScreenKeyboard.NativeMethodInfoPtr_set_characterLimit_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchScreenKeyboard>.NativeClassPtr, 100664587);
			TouchScreenKeyboard.NativeMethodInfoPtr_get_canGetSelection_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchScreenKeyboard>.NativeClassPtr, 100664588);
			TouchScreenKeyboard.NativeMethodInfoPtr_get_canSetSelection_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchScreenKeyboard>.NativeClassPtr, 100664589);
			TouchScreenKeyboard.NativeMethodInfoPtr_get_selection_Public_get_RangeInt_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchScreenKeyboard>.NativeClassPtr, 100664590);
			TouchScreenKeyboard.NativeMethodInfoPtr_set_selection_Public_set_Void_RangeInt_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchScreenKeyboard>.NativeClassPtr, 100664591);
			TouchScreenKeyboard.NativeMethodInfoPtr_GetSelection_Private_Static_Void_byref_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchScreenKeyboard>.NativeClassPtr, 100664592);
			TouchScreenKeyboard.NativeMethodInfoPtr_SetSelection_Private_Static_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchScreenKeyboard>.NativeClassPtr, 100664593);
			TouchScreenKeyboard.get_hideInputDelegateField = IL2CPP.ResolveICall<TouchScreenKeyboard.get_hideInputDelegate>("UnityEngine.TouchScreenKeyboard::get_hideInput");
			TouchScreenKeyboard.GetDoneDelegateField = IL2CPP.ResolveICall<TouchScreenKeyboard.GetDoneDelegate>("UnityEngine.TouchScreenKeyboard::GetDone");
			TouchScreenKeyboard.GetWasCanceledDelegateField = IL2CPP.ResolveICall<TouchScreenKeyboard.GetWasCanceledDelegate>("UnityEngine.TouchScreenKeyboard::GetWasCanceled");
			TouchScreenKeyboard.get_characterLimitDelegateField = IL2CPP.ResolveICall<TouchScreenKeyboard.get_characterLimitDelegate>("UnityEngine.TouchScreenKeyboard::get_characterLimit");
			TouchScreenKeyboard.get_typeDelegateField = IL2CPP.ResolveICall<TouchScreenKeyboard.get_typeDelegate>("UnityEngine.TouchScreenKeyboard::get_type");
			TouchScreenKeyboard.get_visibleDelegateField = IL2CPP.ResolveICall<TouchScreenKeyboard.get_visibleDelegate>("UnityEngine.TouchScreenKeyboard::get_visible");
			TouchScreenKeyboard.get_area_InjectedDelegateField = IL2CPP.ResolveICall<TouchScreenKeyboard.get_area_InjectedDelegate>("UnityEngine.TouchScreenKeyboard::get_area_Injected");
		}

		// Token: 0x060012D7 RID: 4823 RVA: 0x00049554 File Offset: 0x00047754
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76872, XrefRangeEnd = 76874, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Internal_Destroy(IntPtr ptr)
		{
			checked
			{
				IntPtr* ptr2 = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr2 = ref ptr;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchScreenKeyboard.NativeMethodInfoPtr_Internal_Destroy_Private_Static_Void_IntPtr_0, 0, (void**)ptr2, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060012D8 RID: 4824 RVA: 0x00049588 File Offset: 0x00047788
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76874, XrefRangeEnd = 76882, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Destroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchScreenKeyboard.NativeMethodInfoPtr_Destroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012D9 RID: 4825 RVA: 0x000495BC File Offset: 0x000477BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76882, XrefRangeEnd = 76893, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void Finalize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TouchScreenKeyboard.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012DA RID: 4826 RVA: 0x000495F8 File Offset: 0x000477F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76893, XrefRangeEnd = 76907, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TouchScreenKeyboard(string text, TouchScreenKeyboardType keyboardType, bool autocorrection, bool multiline, bool secure, bool alert, string textPlaceholder, int characterLimit)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TouchScreenKeyboard>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref keyboardType;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref autocorrection;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref multiline;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref secure;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref alert;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(textPlaceholder);
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref characterLimit;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchScreenKeyboard.NativeMethodInfoPtr__ctor_Public_Void_String_TouchScreenKeyboardType_Boolean_Boolean_Boolean_Boolean_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012DB RID: 4827 RVA: 0x000496AC File Offset: 0x000478AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76907, XrefRangeEnd = 76909, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr TouchScreenKeyboard_InternalConstructorHelper(ref TouchScreenKeyboard_InternalConstructorHelperArguments arguments, string text, string textPlaceholder)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &arguments;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(text);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(textPlaceholder);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchScreenKeyboard.NativeMethodInfoPtr_TouchScreenKeyboard_InternalConstructorHelper_Private_Static_IntPtr_byref_TouchScreenKeyboard_InternalConstructorHelperArguments_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x1700040B RID: 1035
		// (get) Token: 0x060012DC RID: 4828 RVA: 0x00049710 File Offset: 0x00047910
		public unsafe static bool isSupported
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 76910, RefRangeEnd = 76924, XrefRangeStart = 76909, XrefRangeEnd = 76910, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchScreenKeyboard.NativeMethodInfoPtr_get_isSupported_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700040C RID: 1036
		// (get) Token: 0x060012DD RID: 4829 RVA: 0x00049740 File Offset: 0x00047940
		public unsafe static bool isInPlaceEditingAllowed
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 59613, RefRangeEnd = 59618, XrefRangeStart = 59613, XrefRangeEnd = 59618, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchScreenKeyboard.NativeMethodInfoPtr_get_isInPlaceEditingAllowed_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060012DE RID: 4830 RVA: 0x00049770 File Offset: 0x00047970
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 76941, RefRangeEnd = 76942, XrefRangeStart = 76924, XrefRangeEnd = 76941, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TouchScreenKeyboard Open(string text, TouchScreenKeyboardType keyboardType, bool autocorrection, bool multiline, bool secure, bool alert, string textPlaceholder, int characterLimit)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref keyboardType;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref autocorrection;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref multiline;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref secure;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref alert;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(textPlaceholder);
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref characterLimit;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchScreenKeyboard.NativeMethodInfoPtr_Open_Public_Static_TouchScreenKeyboard_String_TouchScreenKeyboardType_Boolean_Boolean_Boolean_Boolean_String_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TouchScreenKeyboard>(intPtr3) : null;
		}

		// Token: 0x1700040D RID: 1037
		// (get) Token: 0x060012DF RID: 4831 RVA: 0x0004981C File Offset: 0x00047A1C
		// (set) Token: 0x060012E0 RID: 4832 RVA: 0x00049854 File Offset: 0x00047A54
		public unsafe string text
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 76944, RefRangeEnd = 76947, XrefRangeStart = 76942, XrefRangeEnd = 76944, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchScreenKeyboard.NativeMethodInfoPtr_get_text_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 76949, RefRangeEnd = 76959, XrefRangeStart = 76947, XrefRangeEnd = 76949, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchScreenKeyboard.NativeMethodInfoPtr_set_text_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700040E RID: 1038
		// (get) Token: 0x060012F6 RID: 4854 RVA: 0x0000B373 File Offset: 0x00009573
		// (set) Token: 0x060012E1 RID: 4833 RVA: 0x00049898 File Offset: 0x00047A98
		public unsafe static bool hideInput
		{
			get
			{
				return TouchScreenKeyboard.get_hideInputDelegateField();
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 76961, RefRangeEnd = 76962, XrefRangeStart = 76959, XrefRangeEnd = 76961, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchScreenKeyboard.NativeMethodInfoPtr_set_hideInput_Public_Static_set_Void_Boolean_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700040F RID: 1039
		// (get) Token: 0x060012E2 RID: 4834 RVA: 0x000498CC File Offset: 0x00047ACC
		// (set) Token: 0x060012E3 RID: 4835 RVA: 0x00049908 File Offset: 0x00047B08
		public unsafe bool active
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 76964, RefRangeEnd = 76969, XrefRangeStart = 76962, XrefRangeEnd = 76964, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchScreenKeyboard.NativeMethodInfoPtr_get_active_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 76971, RefRangeEnd = 76976, XrefRangeStart = 76969, XrefRangeEnd = 76971, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchScreenKeyboard.NativeMethodInfoPtr_set_active_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000410 RID: 1040
		// (get) Token: 0x060012E4 RID: 4836 RVA: 0x00049948 File Offset: 0x00047B48
		public unsafe TouchScreenKeyboard.Status status
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 76978, RefRangeEnd = 76980, XrefRangeStart = 76976, XrefRangeEnd = 76978, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchScreenKeyboard.NativeMethodInfoPtr_get_status_Public_get_Status_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000411 RID: 1041
		// (get) Token: 0x060012FB RID: 4859 RVA: 0x0000B399 File Offset: 0x00009599
		// (set) Token: 0x060012E5 RID: 4837 RVA: 0x00049984 File Offset: 0x00047B84
		public unsafe int characterLimit
		{
			get
			{
				return TouchScreenKeyboard.get_characterLimitDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 76982, RefRangeEnd = 76984, XrefRangeStart = 76980, XrefRangeEnd = 76982, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchScreenKeyboard.NativeMethodInfoPtr_set_characterLimit_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000412 RID: 1042
		// (get) Token: 0x060012E6 RID: 4838 RVA: 0x000499C4 File Offset: 0x00047BC4
		public unsafe bool canGetSelection
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76984, XrefRangeEnd = 76986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchScreenKeyboard.NativeMethodInfoPtr_get_canGetSelection_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000413 RID: 1043
		// (get) Token: 0x060012E7 RID: 4839 RVA: 0x00049A00 File Offset: 0x00047C00
		public unsafe bool canSetSelection
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 76988, RefRangeEnd = 76989, XrefRangeStart = 76986, XrefRangeEnd = 76988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchScreenKeyboard.NativeMethodInfoPtr_get_canSetSelection_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000414 RID: 1044
		// (get) Token: 0x060012E8 RID: 4840 RVA: 0x00049A3C File Offset: 0x00047C3C
		// (set) Token: 0x060012E9 RID: 4841 RVA: 0x00049A78 File Offset: 0x00047C78
		public unsafe RangeInt selection
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 76991, RefRangeEnd = 76993, XrefRangeStart = 76989, XrefRangeEnd = 76991, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchScreenKeyboard.NativeMethodInfoPtr_get_selection_Public_get_RangeInt_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 77005, RefRangeEnd = 77008, XrefRangeStart = 76993, XrefRangeEnd = 77005, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchScreenKeyboard.NativeMethodInfoPtr_set_selection_Public_set_Void_RangeInt_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060012EA RID: 4842 RVA: 0x00049AB8 File Offset: 0x00047CB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77008, XrefRangeEnd = 77010, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GetSelection(out int start, out int length)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &start;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchScreenKeyboard.NativeMethodInfoPtr_GetSelection_Private_Static_Void_byref_Int32_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012EB RID: 4843 RVA: 0x00049AF8 File Offset: 0x00047CF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77010, XrefRangeEnd = 77012, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetSelection(int start, int length)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref start;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchScreenKeyboard.NativeMethodInfoPtr_SetSelection_Private_Static_Void_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012EC RID: 4844 RVA: 0x0000B34F File Offset: 0x0000954F
		public TouchScreenKeyboard(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700040A RID: 1034
		// (get) Token: 0x060012ED RID: 4845 RVA: 0x00049B38 File Offset: 0x00047D38
		// (set) Token: 0x060012EE RID: 4846 RVA: 0x0000B358 File Offset: 0x00009558
		public unsafe IntPtr m_Ptr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchScreenKeyboard.NativeFieldInfoPtr_m_Ptr);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchScreenKeyboard.NativeFieldInfoPtr_m_Ptr)) = value;
			}
		}

		// Token: 0x060012EF RID: 4847 RVA: 0x00049B60 File Offset: 0x00047D60
		public static TouchScreenKeyboard Open(string text, TouchScreenKeyboardType keyboardType, bool autocorrection, bool multiline, bool secure, bool alert, string textPlaceholder)
		{
			int num = 0;
			return TouchScreenKeyboard.Open(text, keyboardType, autocorrection, multiline, secure, alert, textPlaceholder, num);
		}

		// Token: 0x060012F0 RID: 4848 RVA: 0x00049B84 File Offset: 0x00047D84
		public static TouchScreenKeyboard Open(string text, TouchScreenKeyboardType keyboardType, bool autocorrection, bool multiline, bool secure, bool alert)
		{
			int num = 0;
			string text2 = "";
			return TouchScreenKeyboard.Open(text, keyboardType, autocorrection, multiline, secure, alert, text2, num);
		}

		// Token: 0x060012F1 RID: 4849 RVA: 0x00049BB0 File Offset: 0x00047DB0
		public static TouchScreenKeyboard Open(string text, TouchScreenKeyboardType keyboardType, bool autocorrection, bool multiline, bool secure)
		{
			int num = 0;
			string text2 = "";
			bool flag = false;
			return TouchScreenKeyboard.Open(text, keyboardType, autocorrection, multiline, secure, flag, text2, num);
		}

		// Token: 0x060012F2 RID: 4850 RVA: 0x00049BDC File Offset: 0x00047DDC
		public static TouchScreenKeyboard Open(string text, TouchScreenKeyboardType keyboardType, bool autocorrection, bool multiline)
		{
			int num = 0;
			string text2 = "";
			bool flag = false;
			bool flag2 = false;
			return TouchScreenKeyboard.Open(text, keyboardType, autocorrection, multiline, flag2, flag, text2, num);
		}

		// Token: 0x060012F3 RID: 4851 RVA: 0x00049C0C File Offset: 0x00047E0C
		public static TouchScreenKeyboard Open(string text, TouchScreenKeyboardType keyboardType, bool autocorrection)
		{
			int num = 0;
			string text2 = "";
			bool flag = false;
			bool flag2 = false;
			bool flag3 = false;
			return TouchScreenKeyboard.Open(text, keyboardType, autocorrection, flag3, flag2, flag, text2, num);
		}

		// Token: 0x060012F4 RID: 4852 RVA: 0x00049C40 File Offset: 0x00047E40
		public static TouchScreenKeyboard Open(string text, TouchScreenKeyboardType keyboardType)
		{
			int num = 0;
			string text2 = "";
			bool flag = false;
			bool flag2 = false;
			bool flag3 = false;
			bool flag4 = true;
			return TouchScreenKeyboard.Open(text, keyboardType, flag4, flag3, flag2, flag, text2, num);
		}

		// Token: 0x060012F5 RID: 4853 RVA: 0x00049C78 File Offset: 0x00047E78
		public static TouchScreenKeyboard Open(string text)
		{
			int num = 0;
			string text2 = "";
			bool flag = false;
			bool flag2 = false;
			bool flag3 = false;
			bool flag4 = true;
			TouchScreenKeyboardType touchScreenKeyboardType = TouchScreenKeyboardType.Default;
			return TouchScreenKeyboard.Open(text, touchScreenKeyboardType, flag4, flag3, flag2, flag, text2, num);
		}

		// Token: 0x060012F7 RID: 4855 RVA: 0x0000B37F File Offset: 0x0000957F
		public static bool GetDone(IntPtr ptr)
		{
			return TouchScreenKeyboard.GetDoneDelegateField(ptr);
		}

		// Token: 0x17000415 RID: 1045
		// (get) Token: 0x060012F8 RID: 4856 RVA: 0x00049CB4 File Offset: 0x00047EB4
		public bool done
		{
			get
			{
				return TouchScreenKeyboard.GetDone(this.m_Ptr);
			}
		}

		// Token: 0x060012F9 RID: 4857 RVA: 0x0000B38C File Offset: 0x0000958C
		public static bool GetWasCanceled(IntPtr ptr)
		{
			return TouchScreenKeyboard.GetWasCanceledDelegateField(ptr);
		}

		// Token: 0x17000416 RID: 1046
		// (get) Token: 0x060012FA RID: 4858 RVA: 0x00049CD4 File Offset: 0x00047ED4
		public bool wasCanceled
		{
			get
			{
				return TouchScreenKeyboard.GetWasCanceled(this.m_Ptr);
			}
		}

		// Token: 0x17000417 RID: 1047
		// (get) Token: 0x060012FC RID: 4860 RVA: 0x0000B3AB File Offset: 0x000095AB
		public TouchScreenKeyboardType type
		{
			get
			{
				return TouchScreenKeyboard.get_typeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x17000418 RID: 1048
		// (get) Token: 0x060012FD RID: 4861 RVA: 0x00049CF4 File Offset: 0x00047EF4
		// (set) Token: 0x060012FE RID: 4862 RVA: 0x0000B3BD File Offset: 0x000095BD
		public int targetDisplay
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x17000419 RID: 1049
		// (get) Token: 0x060012FF RID: 4863 RVA: 0x00049D08 File Offset: 0x00047F08
		public static Rect area
		{
			get
			{
				Rect rect;
				TouchScreenKeyboard.get_area_Injected(out rect);
				return rect;
			}
		}

		// Token: 0x1700041A RID: 1050
		// (get) Token: 0x06001300 RID: 4864 RVA: 0x0000B3C0 File Offset: 0x000095C0
		public static bool visible
		{
			get
			{
				return TouchScreenKeyboard.get_visibleDelegateField();
			}
		}

		// Token: 0x06001301 RID: 4865 RVA: 0x0000B3CC File Offset: 0x000095CC
		public static void get_area_Injected(out Rect ret)
		{
			TouchScreenKeyboard.get_area_InjectedDelegateField(out ret);
		}

		// Token: 0x04000DF5 RID: 3573
		private static readonly IntPtr NativeFieldInfoPtr_m_Ptr;

		// Token: 0x04000DF6 RID: 3574
		private static readonly IntPtr NativeMethodInfoPtr_Internal_Destroy_Private_Static_Void_IntPtr_0;

		// Token: 0x04000DF7 RID: 3575
		private static readonly IntPtr NativeMethodInfoPtr_Destroy_Private_Void_0;

		// Token: 0x04000DF8 RID: 3576
		private static readonly IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;

		// Token: 0x04000DF9 RID: 3577
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_TouchScreenKeyboardType_Boolean_Boolean_Boolean_Boolean_String_Int32_0;

		// Token: 0x04000DFA RID: 3578
		private static readonly IntPtr NativeMethodInfoPtr_TouchScreenKeyboard_InternalConstructorHelper_Private_Static_IntPtr_byref_TouchScreenKeyboard_InternalConstructorHelperArguments_String_String_0;

		// Token: 0x04000DFB RID: 3579
		private static readonly IntPtr NativeMethodInfoPtr_get_isSupported_Public_Static_get_Boolean_0;

		// Token: 0x04000DFC RID: 3580
		private static readonly IntPtr NativeMethodInfoPtr_get_isInPlaceEditingAllowed_Public_Static_get_Boolean_0;

		// Token: 0x04000DFD RID: 3581
		private static readonly IntPtr NativeMethodInfoPtr_Open_Public_Static_TouchScreenKeyboard_String_TouchScreenKeyboardType_Boolean_Boolean_Boolean_Boolean_String_Int32_0;

		// Token: 0x04000DFE RID: 3582
		private static readonly IntPtr NativeMethodInfoPtr_get_text_Public_get_String_0;

		// Token: 0x04000DFF RID: 3583
		private static readonly IntPtr NativeMethodInfoPtr_set_text_Public_set_Void_String_0;

		// Token: 0x04000E00 RID: 3584
		private static readonly IntPtr NativeMethodInfoPtr_set_hideInput_Public_Static_set_Void_Boolean_0;

		// Token: 0x04000E01 RID: 3585
		private static readonly IntPtr NativeMethodInfoPtr_get_active_Public_get_Boolean_0;

		// Token: 0x04000E02 RID: 3586
		private static readonly IntPtr NativeMethodInfoPtr_set_active_Public_set_Void_Boolean_0;

		// Token: 0x04000E03 RID: 3587
		private static readonly IntPtr NativeMethodInfoPtr_get_status_Public_get_Status_0;

		// Token: 0x04000E04 RID: 3588
		private static readonly IntPtr NativeMethodInfoPtr_set_characterLimit_Public_set_Void_Int32_0;

		// Token: 0x04000E05 RID: 3589
		private static readonly IntPtr NativeMethodInfoPtr_get_canGetSelection_Public_get_Boolean_0;

		// Token: 0x04000E06 RID: 3590
		private static readonly IntPtr NativeMethodInfoPtr_get_canSetSelection_Public_get_Boolean_0;

		// Token: 0x04000E07 RID: 3591
		private static readonly IntPtr NativeMethodInfoPtr_get_selection_Public_get_RangeInt_0;

		// Token: 0x04000E08 RID: 3592
		private static readonly IntPtr NativeMethodInfoPtr_set_selection_Public_set_Void_RangeInt_0;

		// Token: 0x04000E09 RID: 3593
		private static readonly IntPtr NativeMethodInfoPtr_GetSelection_Private_Static_Void_byref_Int32_byref_Int32_0;

		// Token: 0x04000E0A RID: 3594
		private static readonly IntPtr NativeMethodInfoPtr_SetSelection_Private_Static_Void_Int32_Int32_0;

		// Token: 0x04000E0B RID: 3595
		private static readonly TouchScreenKeyboard.get_hideInputDelegate get_hideInputDelegateField;

		// Token: 0x04000E0C RID: 3596
		private static readonly TouchScreenKeyboard.GetDoneDelegate GetDoneDelegateField;

		// Token: 0x04000E0D RID: 3597
		private static readonly TouchScreenKeyboard.GetWasCanceledDelegate GetWasCanceledDelegateField;

		// Token: 0x04000E0E RID: 3598
		private static readonly TouchScreenKeyboard.get_characterLimitDelegate get_characterLimitDelegateField;

		// Token: 0x04000E0F RID: 3599
		private static readonly TouchScreenKeyboard.get_typeDelegate get_typeDelegateField;

		// Token: 0x04000E10 RID: 3600
		private static readonly TouchScreenKeyboard.get_visibleDelegate get_visibleDelegateField;

		// Token: 0x04000E11 RID: 3601
		private static readonly TouchScreenKeyboard.get_area_InjectedDelegate get_area_InjectedDelegateField;

		// Token: 0x0200083A RID: 2106
		public enum Status
		{
			// Token: 0x04001CB2 RID: 7346
			Visible,
			// Token: 0x04001CB3 RID: 7347
			Done,
			// Token: 0x04001CB4 RID: 7348
			Canceled,
			// Token: 0x04001CB5 RID: 7349
			LostFocus
		}

		// Token: 0x0200083B RID: 2107
		// (Invoke) Token: 0x06002E20 RID: 11808
		private delegate bool get_hideInputDelegate();

		// Token: 0x0200083C RID: 2108
		// (Invoke) Token: 0x06002E22 RID: 11810
		private delegate bool GetDoneDelegate(IntPtr ptr);

		// Token: 0x0200083D RID: 2109
		// (Invoke) Token: 0x06002E24 RID: 11812
		private delegate bool GetWasCanceledDelegate(IntPtr ptr);

		// Token: 0x0200083E RID: 2110
		// (Invoke) Token: 0x06002E26 RID: 11814
		private delegate int get_characterLimitDelegate(IntPtr @this);

		// Token: 0x0200083F RID: 2111
		// (Invoke) Token: 0x06002E28 RID: 11816
		private delegate TouchScreenKeyboardType get_typeDelegate(IntPtr @this);

		// Token: 0x02000840 RID: 2112
		// (Invoke) Token: 0x06002E2A RID: 11818
		private delegate bool get_visibleDelegate();

		// Token: 0x02000841 RID: 2113
		// (Invoke) Token: 0x06002E2C RID: 11820
		private delegate void get_area_InjectedDelegate([Out] IntPtr ret);
	}
}
