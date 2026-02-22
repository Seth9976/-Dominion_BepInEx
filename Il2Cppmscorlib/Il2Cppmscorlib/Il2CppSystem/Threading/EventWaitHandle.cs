using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Threading
{
	// Token: 0x0200026B RID: 619
	public class EventWaitHandle : WaitHandle
	{
		// Token: 0x06002AA3 RID: 10915 RVA: 0x000DBF10 File Offset: 0x000DA110
		// Note: this type is marked as 'beforefieldinit'.
		static EventWaitHandle()
		{
			Il2CppClassPointerStore<EventWaitHandle>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading", "EventWaitHandle");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EventWaitHandle>.NativeClassPtr);
			EventWaitHandle.NativeMethodInfoPtr__ctor_Public_Void_Boolean_EventResetMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventWaitHandle>.NativeClassPtr, 100670071);
			EventWaitHandle.NativeMethodInfoPtr__ctor_Public_Void_Boolean_EventResetMode_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventWaitHandle>.NativeClassPtr, 100670072);
			EventWaitHandle.NativeMethodInfoPtr_Reset_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventWaitHandle>.NativeClassPtr, 100670073);
			EventWaitHandle.NativeMethodInfoPtr_Set_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventWaitHandle>.NativeClassPtr, 100670074);
		}

		// Token: 0x06002AA4 RID: 10916 RVA: 0x000DBF90 File Offset: 0x000DA190
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 331249, RefRangeEnd = 331252, XrefRangeStart = 331248, XrefRangeEnd = 331249, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EventWaitHandle(bool initialState, EventResetMode mode)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EventWaitHandle>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref initialState;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventWaitHandle.NativeMethodInfoPtr__ctor_Public_Void_Boolean_EventResetMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002AA5 RID: 10917 RVA: 0x000DBFE8 File Offset: 0x000DA1E8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 331267, RefRangeEnd = 331268, XrefRangeStart = 331252, XrefRangeEnd = 331267, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EventWaitHandle(bool initialState, EventResetMode mode, string name)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EventWaitHandle>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref initialState;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mode;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventWaitHandle.NativeMethodInfoPtr__ctor_Public_Void_Boolean_EventResetMode_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002AA6 RID: 10918 RVA: 0x000DC050 File Offset: 0x000DA250
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 331270, RefRangeEnd = 331273, XrefRangeStart = 331268, XrefRangeEnd = 331270, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventWaitHandle.NativeMethodInfoPtr_Reset_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002AA7 RID: 10919 RVA: 0x000DC08C File Offset: 0x000DA28C
		[CallerCount(16)]
		[CachedScanResults(RefRangeStart = 331275, RefRangeEnd = 331291, XrefRangeStart = 331273, XrefRangeEnd = 331275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Set()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventWaitHandle.NativeMethodInfoPtr_Set_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002AA8 RID: 10920 RVA: 0x0000EE10 File Offset: 0x0000D010
		public EventWaitHandle(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04002556 RID: 9558
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_EventResetMode_0;

		// Token: 0x04002557 RID: 9559
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_EventResetMode_String_0;

		// Token: 0x04002558 RID: 9560
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Boolean_0;

		// Token: 0x04002559 RID: 9561
		private static readonly IntPtr NativeMethodInfoPtr_Set_Public_Boolean_0;
	}
}
