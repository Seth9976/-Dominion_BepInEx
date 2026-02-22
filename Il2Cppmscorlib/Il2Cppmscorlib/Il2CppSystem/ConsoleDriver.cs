using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem
{
	// Token: 0x0200010F RID: 271
	public static class ConsoleDriver : Object
	{
		// Token: 0x06001404 RID: 5124 RVA: 0x0007DAA4 File Offset: 0x0007BCA4
		// Note: this type is marked as 'beforefieldinit'.
		static ConsoleDriver()
		{
			Il2CppClassPointerStore<ConsoleDriver>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "ConsoleDriver");
			ConsoleDriver.NativeFieldInfoPtr_driver = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConsoleDriver>.NativeClassPtr, "driver");
			ConsoleDriver.NativeFieldInfoPtr_is_console = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConsoleDriver>.NativeClassPtr, "is_console");
			ConsoleDriver.NativeFieldInfoPtr_called_isatty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConsoleDriver>.NativeClassPtr, "called_isatty");
			ConsoleDriver.NativeMethodInfoPtr_CreateNullConsoleDriver_Private_Static_IConsoleDriver_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConsoleDriver>.NativeClassPtr, 100666732);
			ConsoleDriver.NativeMethodInfoPtr_CreateWindowsConsoleDriver_Private_Static_IConsoleDriver_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConsoleDriver>.NativeClassPtr, 100666733);
			ConsoleDriver.NativeMethodInfoPtr_CreateTermInfoDriver_Private_Static_IConsoleDriver_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConsoleDriver>.NativeClassPtr, 100666734);
			ConsoleDriver.NativeMethodInfoPtr_ReadKey_Public_Static_ConsoleKeyInfo_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConsoleDriver>.NativeClassPtr, 100666735);
			ConsoleDriver.NativeMethodInfoPtr_get_IsConsole_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConsoleDriver>.NativeClassPtr, 100666736);
			ConsoleDriver.NativeMethodInfoPtr_Isatty_Private_Static_Boolean_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConsoleDriver>.NativeClassPtr, 100666737);
			ConsoleDriver.NativeMethodInfoPtr_InternalKeyAvailable_Internal_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConsoleDriver>.NativeClassPtr, 100666738);
			ConsoleDriver.NativeMethodInfoPtr_TtySetup_Internal_Static_Boolean_String_String_byref_Il2CppStructArray_1_Byte_byref_ptr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConsoleDriver>.NativeClassPtr, 100666739);
			ConsoleDriver.NativeMethodInfoPtr_SetEcho_Internal_Static_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConsoleDriver>.NativeClassPtr, 100666740);
		}

		// Token: 0x06001405 RID: 5125 RVA: 0x0007DBBC File Offset: 0x0007BDBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 304810, XrefRangeEnd = 304814, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IConsoleDriver CreateNullConsoleDriver()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConsoleDriver.NativeMethodInfoPtr_CreateNullConsoleDriver_Private_Static_IConsoleDriver_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IConsoleDriver>(intPtr3) : null;
		}

		// Token: 0x06001406 RID: 5126 RVA: 0x0007DBF0 File Offset: 0x0007BDF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 304814, XrefRangeEnd = 304818, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IConsoleDriver CreateWindowsConsoleDriver()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConsoleDriver.NativeMethodInfoPtr_CreateWindowsConsoleDriver_Private_Static_IConsoleDriver_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IConsoleDriver>(intPtr3) : null;
		}

		// Token: 0x06001407 RID: 5127 RVA: 0x0007DC24 File Offset: 0x0007BE24
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 304822, RefRangeEnd = 304823, XrefRangeStart = 304818, XrefRangeEnd = 304822, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IConsoleDriver CreateTermInfoDriver(string term)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(term);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConsoleDriver.NativeMethodInfoPtr_CreateTermInfoDriver_Private_Static_IConsoleDriver_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IConsoleDriver>(intPtr3) : null;
			}
		}

		// Token: 0x06001408 RID: 5128 RVA: 0x0007DC68 File Offset: 0x0007BE68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 304823, XrefRangeEnd = 304830, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ConsoleKeyInfo ReadKey(bool intercept)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref intercept;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConsoleDriver.NativeMethodInfoPtr_ReadKey_Public_Static_ConsoleKeyInfo_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170003C8 RID: 968
		// (get) Token: 0x06001409 RID: 5129 RVA: 0x0007DCA8 File Offset: 0x0007BEA8
		public unsafe static bool IsConsole
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 304853, RefRangeEnd = 304856, XrefRangeStart = 304830, XrefRangeEnd = 304853, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConsoleDriver.NativeMethodInfoPtr_get_IsConsole_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600140A RID: 5130 RVA: 0x0007DCD8 File Offset: 0x0007BED8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 304856, XrefRangeEnd = 304857, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Isatty(IntPtr handle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConsoleDriver.NativeMethodInfoPtr_Isatty_Private_Static_Boolean_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600140B RID: 5131 RVA: 0x0007DD18 File Offset: 0x0007BF18
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 304858, RefRangeEnd = 304863, XrefRangeStart = 304857, XrefRangeEnd = 304858, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int InternalKeyAvailable(int ms_timeout)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ms_timeout;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConsoleDriver.NativeMethodInfoPtr_InternalKeyAvailable_Internal_Static_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600140C RID: 5132 RVA: 0x0007DD58 File Offset: 0x0007BF58
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 304875, RefRangeEnd = 304876, XrefRangeStart = 304863, XrefRangeEnd = 304875, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TtySetup(string keypadXmit, string teardown, out Il2CppStructArray<byte> control_characters, out int* address)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(keypadXmit);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(teardown);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = 0;
			ptr3 = &intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(ConsoleDriver.NativeMethodInfoPtr_TtySetup_Internal_Static_Boolean_String_String_byref_Il2CppStructArray_1_Byte_byref_ptr_Int32_0, 0, (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			IntPtr intPtr5 = intPtr;
			control_characters = ((intPtr5 == 0) ? null : new Il2CppStructArray<byte>(intPtr5));
			IntPtr intPtr6 = intPtr2;
			address = ((intPtr6 == 0) ? null : new int*(intPtr6));
			return *IL2CPP.il2cpp_object_unbox(intPtr3);
		}

		// Token: 0x0600140D RID: 5133 RVA: 0x0007DDF4 File Offset: 0x0007BFF4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 304884, RefRangeEnd = 304885, XrefRangeStart = 304876, XrefRangeEnd = 304884, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool SetEcho(bool wantEcho)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref wantEcho;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConsoleDriver.NativeMethodInfoPtr_SetEcho_Internal_Static_Boolean_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600140E RID: 5134 RVA: 0x00006FED File Offset: 0x000051ED
		public ConsoleDriver(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003C5 RID: 965
		// (get) Token: 0x0600140F RID: 5135 RVA: 0x0007DE34 File Offset: 0x0007C034
		// (set) Token: 0x06001410 RID: 5136 RVA: 0x00006FF6 File Offset: 0x000051F6
		public unsafe static IConsoleDriver driver
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ConsoleDriver.NativeFieldInfoPtr_driver, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IConsoleDriver>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ConsoleDriver.NativeFieldInfoPtr_driver, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003C6 RID: 966
		// (get) Token: 0x06001411 RID: 5137 RVA: 0x0007DE5C File Offset: 0x0007C05C
		// (set) Token: 0x06001412 RID: 5138 RVA: 0x00007008 File Offset: 0x00005208
		public unsafe static bool is_console
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(ConsoleDriver.NativeFieldInfoPtr_is_console, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ConsoleDriver.NativeFieldInfoPtr_is_console, (void*)(&value));
			}
		}

		// Token: 0x170003C7 RID: 967
		// (get) Token: 0x06001413 RID: 5139 RVA: 0x0007DE78 File Offset: 0x0007C078
		// (set) Token: 0x06001414 RID: 5140 RVA: 0x00007016 File Offset: 0x00005216
		public unsafe static bool called_isatty
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(ConsoleDriver.NativeFieldInfoPtr_called_isatty, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ConsoleDriver.NativeFieldInfoPtr_called_isatty, (void*)(&value));
			}
		}

		// Token: 0x04001122 RID: 4386
		private static readonly IntPtr NativeFieldInfoPtr_driver;

		// Token: 0x04001123 RID: 4387
		private static readonly IntPtr NativeFieldInfoPtr_is_console;

		// Token: 0x04001124 RID: 4388
		private static readonly IntPtr NativeFieldInfoPtr_called_isatty;

		// Token: 0x04001125 RID: 4389
		private static readonly IntPtr NativeMethodInfoPtr_CreateNullConsoleDriver_Private_Static_IConsoleDriver_0;

		// Token: 0x04001126 RID: 4390
		private static readonly IntPtr NativeMethodInfoPtr_CreateWindowsConsoleDriver_Private_Static_IConsoleDriver_0;

		// Token: 0x04001127 RID: 4391
		private static readonly IntPtr NativeMethodInfoPtr_CreateTermInfoDriver_Private_Static_IConsoleDriver_String_0;

		// Token: 0x04001128 RID: 4392
		private static readonly IntPtr NativeMethodInfoPtr_ReadKey_Public_Static_ConsoleKeyInfo_Boolean_0;

		// Token: 0x04001129 RID: 4393
		private static readonly IntPtr NativeMethodInfoPtr_get_IsConsole_Public_Static_get_Boolean_0;

		// Token: 0x0400112A RID: 4394
		private static readonly IntPtr NativeMethodInfoPtr_Isatty_Private_Static_Boolean_IntPtr_0;

		// Token: 0x0400112B RID: 4395
		private static readonly IntPtr NativeMethodInfoPtr_InternalKeyAvailable_Internal_Static_Int32_Int32_0;

		// Token: 0x0400112C RID: 4396
		private static readonly IntPtr NativeMethodInfoPtr_TtySetup_Internal_Static_Boolean_String_String_byref_Il2CppStructArray_1_Byte_byref_ptr_Int32_0;

		// Token: 0x0400112D RID: 4397
		private static readonly IntPtr NativeMethodInfoPtr_SetEcho_Internal_Static_Boolean_Boolean_0;
	}
}
