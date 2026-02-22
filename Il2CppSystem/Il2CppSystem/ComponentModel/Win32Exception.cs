using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Runtime.InteropServices;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem.ComponentModel
{
	// Token: 0x02000075 RID: 117
	[Serializable]
	public class Win32Exception : ExternalException
	{
		// Token: 0x060007BD RID: 1981 RVA: 0x0002CCC4 File Offset: 0x0002AEC4
		// Note: this type is marked as 'beforefieldinit'.
		static Win32Exception()
		{
			Il2CppClassPointerStore<Win32Exception>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.ComponentModel", "Win32Exception");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Win32Exception>.NativeClassPtr);
			Win32Exception.NativeFieldInfoPtr_nativeErrorCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Win32Exception>.NativeClassPtr, "nativeErrorCode");
			Win32Exception.NativeFieldInfoPtr_s_ErrorMessagesInitialized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Win32Exception>.NativeClassPtr, "s_ErrorMessagesInitialized");
			Win32Exception.NativeFieldInfoPtr_s_ErrorMessage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Win32Exception>.NativeClassPtr, "s_ErrorMessage");
			Win32Exception.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Win32Exception>.NativeClassPtr, 100664295);
			Win32Exception.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Win32Exception>.NativeClassPtr, 100664296);
			Win32Exception.NativeMethodInfoPtr__ctor_Public_Void_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Win32Exception>.NativeClassPtr, 100664297);
			Win32Exception.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Win32Exception>.NativeClassPtr, 100664298);
			Win32Exception.NativeMethodInfoPtr_get_NativeErrorCode_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Win32Exception>.NativeClassPtr, 100664299);
			Win32Exception.NativeMethodInfoPtr_GetObjectData_Public_Virtual_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Win32Exception>.NativeClassPtr, 100664300);
			Win32Exception.NativeMethodInfoPtr_GetErrorMessage_Internal_Static_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Win32Exception>.NativeClassPtr, 100664301);
			Win32Exception.NativeMethodInfoPtr_InitializeErrorMessages_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Win32Exception>.NativeClassPtr, 100664302);
			Win32Exception.NativeMethodInfoPtr_InitializeErrorMessages1_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Win32Exception>.NativeClassPtr, 100664303);
		}

		// Token: 0x060007BE RID: 1982 RVA: 0x0002CDE4 File Offset: 0x0002AFE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 40963, XrefRangeEnd = 40991, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Win32Exception()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Win32Exception>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Win32Exception.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007BF RID: 1983 RVA: 0x0002CE20 File Offset: 0x0002B020
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 41015, RefRangeEnd = 41020, XrefRangeStart = 40991, XrefRangeEnd = 41015, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Win32Exception(int error)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Win32Exception>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref error;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Win32Exception.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060007C0 RID: 1984 RVA: 0x0002CE68 File Offset: 0x0002B068
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 41021, RefRangeEnd = 41022, XrefRangeStart = 41020, XrefRangeEnd = 41021, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Win32Exception(int error, string message)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Win32Exception>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref error;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(message);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Win32Exception.NativeMethodInfoPtr__ctor_Public_Void_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007C1 RID: 1985 RVA: 0x0002CEC4 File Offset: 0x0002B0C4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 41026, RefRangeEnd = 41028, XrefRangeStart = 41022, XrefRangeEnd = 41026, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Win32Exception(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Win32Exception>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Win32Exception.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000257 RID: 599
		// (get) Token: 0x060007C2 RID: 1986 RVA: 0x0002CF28 File Offset: 0x0002B128
		public unsafe int NativeErrorCode
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 41028, RefRangeEnd = 41035, XrefRangeStart = 41028, XrefRangeEnd = 41028, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Win32Exception.NativeMethodInfoPtr_get_NativeErrorCode_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060007C3 RID: 1987 RVA: 0x0002CF64 File Offset: 0x0002B164
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 41035, XrefRangeEnd = 41039, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void GetObjectData(SerializationInfo info, StreamingContext context)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Win32Exception.NativeMethodInfoPtr_GetObjectData_Public_Virtual_Void_SerializationInfo_StreamingContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007C4 RID: 1988 RVA: 0x0002CFC8 File Offset: 0x0002B1C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 41039, XrefRangeEnd = 41057, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetErrorMessage(int error)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref error;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Win32Exception.NativeMethodInfoPtr_GetErrorMessage_Internal_Static_String_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060007C5 RID: 1989 RVA: 0x0002D000 File Offset: 0x0002B200
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 41073, RefRangeEnd = 41076, XrefRangeStart = 41057, XrefRangeEnd = 41073, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InitializeErrorMessages()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Win32Exception.NativeMethodInfoPtr_InitializeErrorMessages_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007C6 RID: 1990 RVA: 0x0002D028 File Offset: 0x0002B228
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 41346, RefRangeEnd = 41347, XrefRangeStart = 41076, XrefRangeEnd = 41346, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InitializeErrorMessages1()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Win32Exception.NativeMethodInfoPtr_InitializeErrorMessages1_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007C7 RID: 1991 RVA: 0x000052BB File Offset: 0x000034BB
		public Win32Exception(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000254 RID: 596
		// (get) Token: 0x060007C8 RID: 1992 RVA: 0x0002D050 File Offset: 0x0002B250
		// (set) Token: 0x060007C9 RID: 1993 RVA: 0x000052C4 File Offset: 0x000034C4
		public unsafe int nativeErrorCode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Win32Exception.NativeFieldInfoPtr_nativeErrorCode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Win32Exception.NativeFieldInfoPtr_nativeErrorCode)) = value;
			}
		}

		// Token: 0x17000255 RID: 597
		// (get) Token: 0x060007CA RID: 1994 RVA: 0x0002D078 File Offset: 0x0002B278
		// (set) Token: 0x060007CB RID: 1995 RVA: 0x000052DF File Offset: 0x000034DF
		public unsafe static bool s_ErrorMessagesInitialized
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(Win32Exception.NativeFieldInfoPtr_s_ErrorMessagesInitialized, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Win32Exception.NativeFieldInfoPtr_s_ErrorMessagesInitialized, (void*)(&value));
			}
		}

		// Token: 0x17000256 RID: 598
		// (get) Token: 0x060007CC RID: 1996 RVA: 0x0002D094 File Offset: 0x0002B294
		// (set) Token: 0x060007CD RID: 1997 RVA: 0x000052ED File Offset: 0x000034ED
		public unsafe static Dictionary<int, string> s_ErrorMessage
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Win32Exception.NativeFieldInfoPtr_s_ErrorMessage, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, string>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Win32Exception.NativeFieldInfoPtr_s_ErrorMessage, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040005A7 RID: 1447
		private static readonly IntPtr NativeFieldInfoPtr_nativeErrorCode;

		// Token: 0x040005A8 RID: 1448
		private static readonly IntPtr NativeFieldInfoPtr_s_ErrorMessagesInitialized;

		// Token: 0x040005A9 RID: 1449
		private static readonly IntPtr NativeFieldInfoPtr_s_ErrorMessage;

		// Token: 0x040005AA RID: 1450
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040005AB RID: 1451
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x040005AC RID: 1452
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_String_0;

		// Token: 0x040005AD RID: 1453
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x040005AE RID: 1454
		private static readonly IntPtr NativeMethodInfoPtr_get_NativeErrorCode_Public_get_Int32_0;

		// Token: 0x040005AF RID: 1455
		private static readonly IntPtr NativeMethodInfoPtr_GetObjectData_Public_Virtual_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x040005B0 RID: 1456
		private static readonly IntPtr NativeMethodInfoPtr_GetErrorMessage_Internal_Static_String_Int32_0;

		// Token: 0x040005B1 RID: 1457
		private static readonly IntPtr NativeMethodInfoPtr_InitializeErrorMessages_Private_Static_Void_0;

		// Token: 0x040005B2 RID: 1458
		private static readonly IntPtr NativeMethodInfoPtr_InitializeErrorMessages1_Public_Static_Void_0;
	}
}
