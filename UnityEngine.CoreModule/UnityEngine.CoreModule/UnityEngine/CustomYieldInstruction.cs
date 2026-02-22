using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x020000B0 RID: 176
	public class CustomYieldInstruction : Object
	{
		// Token: 0x0600104C RID: 4172 RVA: 0x00042BE4 File Offset: 0x00040DE4
		// Note: this type is marked as 'beforefieldinit'.
		static CustomYieldInstruction()
		{
			Il2CppClassPointerStore<CustomYieldInstruction>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "CustomYieldInstruction");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CustomYieldInstruction>.NativeClassPtr);
			CustomYieldInstruction.NativeMethodInfoPtr_get_keepWaiting_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomYieldInstruction>.NativeClassPtr, 100664363);
			CustomYieldInstruction.NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomYieldInstruction>.NativeClassPtr, 100664364);
			CustomYieldInstruction.NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomYieldInstruction>.NativeClassPtr, 100664365);
			CustomYieldInstruction.NativeMethodInfoPtr_Reset_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomYieldInstruction>.NativeClassPtr, 100664366);
			CustomYieldInstruction.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomYieldInstruction>.NativeClassPtr, 100664367);
		}

		// Token: 0x1700036E RID: 878
		// (get) Token: 0x0600104D RID: 4173 RVA: 0x00042C78 File Offset: 0x00040E78
		public unsafe virtual bool keepWaiting
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CustomYieldInstruction.NativeMethodInfoPtr_get_keepWaiting_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700036F RID: 879
		// (get) Token: 0x0600104E RID: 4174 RVA: 0x00042CC0 File Offset: 0x00040EC0
		public unsafe virtual Object Current
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomYieldInstruction.NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x0600104F RID: 4175 RVA: 0x00042D00 File Offset: 0x00040F00
		[CallerCount(16)]
		[CachedScanResults(RefRangeStart = 14894, RefRangeEnd = 14910, XrefRangeStart = 14894, XrefRangeEnd = 14910, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomYieldInstruction.NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001050 RID: 4176 RVA: 0x00042D3C File Offset: 0x00040F3C
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CustomYieldInstruction.NativeMethodInfoPtr_Reset_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001051 RID: 4177 RVA: 0x00042D78 File Offset: 0x00040F78
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CustomYieldInstruction()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CustomYieldInstruction>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomYieldInstruction.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001052 RID: 4178 RVA: 0x0000A1B7 File Offset: 0x000083B7
		public CustomYieldInstruction(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000C4C RID: 3148
		private static readonly IntPtr NativeMethodInfoPtr_get_keepWaiting_Public_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x04000C4D RID: 3149
		private static readonly IntPtr NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_Object_0;

		// Token: 0x04000C4E RID: 3150
		private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0;

		// Token: 0x04000C4F RID: 3151
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Virtual_New_Void_0;

		// Token: 0x04000C50 RID: 3152
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
