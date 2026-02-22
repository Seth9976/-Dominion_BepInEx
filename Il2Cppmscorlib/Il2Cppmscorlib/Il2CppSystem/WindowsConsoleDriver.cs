using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem
{
	// Token: 0x02000151 RID: 337
	public class WindowsConsoleDriver : Object
	{
		// Token: 0x06001723 RID: 5923 RVA: 0x00089FC4 File Offset: 0x000881C4
		// Note: this type is marked as 'beforefieldinit'.
		static WindowsConsoleDriver()
		{
			Il2CppClassPointerStore<WindowsConsoleDriver>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "WindowsConsoleDriver");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WindowsConsoleDriver>.NativeClassPtr);
			WindowsConsoleDriver.NativeFieldInfoPtr_inputHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WindowsConsoleDriver>.NativeClassPtr, "inputHandle");
			WindowsConsoleDriver.NativeFieldInfoPtr_outputHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WindowsConsoleDriver>.NativeClassPtr, "outputHandle");
			WindowsConsoleDriver.NativeFieldInfoPtr_defaultAttribute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WindowsConsoleDriver>.NativeClassPtr, "defaultAttribute");
			WindowsConsoleDriver.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowsConsoleDriver>.NativeClassPtr, 100667166);
			WindowsConsoleDriver.NativeMethodInfoPtr_ReadKey_Public_Virtual_Final_New_ConsoleKeyInfo_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowsConsoleDriver>.NativeClassPtr, 100667167);
			WindowsConsoleDriver.NativeMethodInfoPtr_IsModifierKey_Private_Static_Boolean_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowsConsoleDriver>.NativeClassPtr, 100667168);
			WindowsConsoleDriver.NativeMethodInfoPtr_GetStdHandle_Private_Static_IntPtr_Handles_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowsConsoleDriver>.NativeClassPtr, 100667169);
			WindowsConsoleDriver.NativeMethodInfoPtr_GetConsoleScreenBufferInfo_Private_Static_Boolean_IntPtr_byref_ConsoleScreenBufferInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowsConsoleDriver>.NativeClassPtr, 100667170);
			WindowsConsoleDriver.NativeMethodInfoPtr_ReadConsoleInput_Private_Static_Boolean_IntPtr_byref_InputRecord_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowsConsoleDriver>.NativeClassPtr, 100667171);
		}

		// Token: 0x06001724 RID: 5924 RVA: 0x0008A0A8 File Offset: 0x000882A8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 309550, RefRangeEnd = 309551, XrefRangeStart = 309544, XrefRangeEnd = 309550, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WindowsConsoleDriver()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WindowsConsoleDriver>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WindowsConsoleDriver.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001725 RID: 5925 RVA: 0x0008A0E4 File Offset: 0x000882E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309551, XrefRangeEnd = 309557, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual ConsoleKeyInfo ReadKey(bool intercept)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref intercept;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WindowsConsoleDriver.NativeMethodInfoPtr_ReadKey_Public_Virtual_Final_New_ConsoleKeyInfo_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001726 RID: 5926 RVA: 0x0008A130 File Offset: 0x00088330
		[CallerCount(0)]
		public unsafe static bool IsModifierKey(short virtualKeyCode)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref virtualKeyCode;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WindowsConsoleDriver.NativeMethodInfoPtr_IsModifierKey_Private_Static_Boolean_Int16_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001727 RID: 5927 RVA: 0x0008A170 File Offset: 0x00088370
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 309560, RefRangeEnd = 309562, XrefRangeStart = 309557, XrefRangeEnd = 309560, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr GetStdHandle(Handles handle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WindowsConsoleDriver.NativeMethodInfoPtr_GetStdHandle_Private_Static_IntPtr_Handles_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001728 RID: 5928 RVA: 0x0008A1B0 File Offset: 0x000883B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309562, XrefRangeEnd = 309565, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetConsoleScreenBufferInfo(IntPtr handle, out ConsoleScreenBufferInfo info)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &info;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WindowsConsoleDriver.NativeMethodInfoPtr_GetConsoleScreenBufferInfo_Private_Static_Boolean_IntPtr_byref_ConsoleScreenBufferInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001729 RID: 5929 RVA: 0x0008A1FC File Offset: 0x000883FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309565, XrefRangeEnd = 309570, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ReadConsoleInput(IntPtr handle, out InputRecord record, int length, out int nread)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &record;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &nread;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WindowsConsoleDriver.NativeMethodInfoPtr_ReadConsoleInput_Private_Static_Boolean_IntPtr_byref_InputRecord_Int32_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600172A RID: 5930 RVA: 0x000082AF File Offset: 0x000064AF
		public WindowsConsoleDriver(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000472 RID: 1138
		// (get) Token: 0x0600172B RID: 5931 RVA: 0x0008A264 File Offset: 0x00088464
		// (set) Token: 0x0600172C RID: 5932 RVA: 0x000082B8 File Offset: 0x000064B8
		public unsafe IntPtr inputHandle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WindowsConsoleDriver.NativeFieldInfoPtr_inputHandle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WindowsConsoleDriver.NativeFieldInfoPtr_inputHandle)) = value;
			}
		}

		// Token: 0x17000473 RID: 1139
		// (get) Token: 0x0600172D RID: 5933 RVA: 0x0008A28C File Offset: 0x0008848C
		// (set) Token: 0x0600172E RID: 5934 RVA: 0x000082D3 File Offset: 0x000064D3
		public unsafe IntPtr outputHandle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WindowsConsoleDriver.NativeFieldInfoPtr_outputHandle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WindowsConsoleDriver.NativeFieldInfoPtr_outputHandle)) = value;
			}
		}

		// Token: 0x17000474 RID: 1140
		// (get) Token: 0x0600172F RID: 5935 RVA: 0x0008A2B4 File Offset: 0x000884B4
		// (set) Token: 0x06001730 RID: 5936 RVA: 0x000082EE File Offset: 0x000064EE
		public unsafe short defaultAttribute
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WindowsConsoleDriver.NativeFieldInfoPtr_defaultAttribute);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WindowsConsoleDriver.NativeFieldInfoPtr_defaultAttribute)) = value;
			}
		}

		// Token: 0x04001577 RID: 5495
		private static readonly IntPtr NativeFieldInfoPtr_inputHandle;

		// Token: 0x04001578 RID: 5496
		private static readonly IntPtr NativeFieldInfoPtr_outputHandle;

		// Token: 0x04001579 RID: 5497
		private static readonly IntPtr NativeFieldInfoPtr_defaultAttribute;

		// Token: 0x0400157A RID: 5498
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400157B RID: 5499
		private static readonly IntPtr NativeMethodInfoPtr_ReadKey_Public_Virtual_Final_New_ConsoleKeyInfo_Boolean_0;

		// Token: 0x0400157C RID: 5500
		private static readonly IntPtr NativeMethodInfoPtr_IsModifierKey_Private_Static_Boolean_Int16_0;

		// Token: 0x0400157D RID: 5501
		private static readonly IntPtr NativeMethodInfoPtr_GetStdHandle_Private_Static_IntPtr_Handles_0;

		// Token: 0x0400157E RID: 5502
		private static readonly IntPtr NativeMethodInfoPtr_GetConsoleScreenBufferInfo_Private_Static_Boolean_IntPtr_byref_ConsoleScreenBufferInfo_0;

		// Token: 0x0400157F RID: 5503
		private static readonly IntPtr NativeMethodInfoPtr_ReadConsoleInput_Private_Static_Boolean_IntPtr_byref_InputRecord_Int32_byref_Int32_0;
	}
}
