using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine.Events;

namespace UnityEngine
{
	// Token: 0x02000049 RID: 73
	public static class BeforeRenderHelper : Object
	{
		// Token: 0x060004E9 RID: 1257 RVA: 0x0002229C File Offset: 0x0002049C
		// Note: this type is marked as 'beforefieldinit'.
		static BeforeRenderHelper()
		{
			Il2CppClassPointerStore<BeforeRenderHelper>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "BeforeRenderHelper");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BeforeRenderHelper>.NativeClassPtr);
			BeforeRenderHelper.NativeFieldInfoPtr_s_OrderBlocks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BeforeRenderHelper>.NativeClassPtr, "s_OrderBlocks");
			BeforeRenderHelper.NativeMethodInfoPtr_Invoke_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeforeRenderHelper>.NativeClassPtr, 100663579);
		}

		// Token: 0x060004EA RID: 1258 RVA: 0x000222F4 File Offset: 0x000204F4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 62488, RefRangeEnd = 62489, XrefRangeStart = 62468, XrefRangeEnd = 62488, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Invoke()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BeforeRenderHelper.NativeMethodInfoPtr_Invoke_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004EB RID: 1259 RVA: 0x00004E14 File Offset: 0x00003014
		public BeforeRenderHelper(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700012A RID: 298
		// (get) Token: 0x060004EC RID: 1260 RVA: 0x0002231C File Offset: 0x0002051C
		// (set) Token: 0x060004ED RID: 1261 RVA: 0x00004E1D File Offset: 0x0000301D
		public unsafe static List<BeforeRenderHelper.OrderBlock> s_OrderBlocks
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BeforeRenderHelper.NativeFieldInfoPtr_s_OrderBlocks, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<BeforeRenderHelper.OrderBlock>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BeforeRenderHelper.NativeFieldInfoPtr_s_OrderBlocks, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x060004EE RID: 1262 RVA: 0x00004E2F File Offset: 0x0000302F
		public static int GetUpdateOrder(UnityEngine.Events.UnityAction callback)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060004EF RID: 1263 RVA: 0x00004E3C File Offset: 0x0000303C
		public static void RegisterCallback(UnityEngine.Events.UnityAction callback)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060004F0 RID: 1264 RVA: 0x00004E49 File Offset: 0x00003049
		public static void UnregisterCallback(UnityEngine.Events.UnityAction callback)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x04000354 RID: 852
		private static readonly IntPtr NativeFieldInfoPtr_s_OrderBlocks;

		// Token: 0x04000355 RID: 853
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Static_Void_0;

		// Token: 0x02000454 RID: 1108
		public sealed class OrderBlock : ValueType
		{
			// Token: 0x0600266C RID: 9836 RVA: 0x0006B808 File Offset: 0x00069A08
			// Note: this type is marked as 'beforefieldinit'.
			static OrderBlock()
			{
				Il2CppClassPointerStore<BeforeRenderHelper.OrderBlock>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BeforeRenderHelper>.NativeClassPtr, "OrderBlock");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BeforeRenderHelper.OrderBlock>.NativeClassPtr);
				BeforeRenderHelper.OrderBlock.NativeFieldInfoPtr_order = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BeforeRenderHelper.OrderBlock>.NativeClassPtr, "order");
				BeforeRenderHelper.OrderBlock.NativeFieldInfoPtr_callback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BeforeRenderHelper.OrderBlock>.NativeClassPtr, "callback");
			}

			// Token: 0x0600266D RID: 9837 RVA: 0x0001526B File Offset: 0x0001346B
			public OrderBlock(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0600266E RID: 9838 RVA: 0x00015274 File Offset: 0x00013474
			public OrderBlock()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BeforeRenderHelper.OrderBlock>.NativeClassPtr))
			{
			}

			// Token: 0x1700076A RID: 1898
			// (get) Token: 0x0600266F RID: 9839 RVA: 0x0006B85C File Offset: 0x00069A5C
			// (set) Token: 0x06002670 RID: 9840 RVA: 0x00015286 File Offset: 0x00013486
			public unsafe int order
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BeforeRenderHelper.OrderBlock.NativeFieldInfoPtr_order);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BeforeRenderHelper.OrderBlock.NativeFieldInfoPtr_order)) = value;
				}
			}

			// Token: 0x1700076B RID: 1899
			// (get) Token: 0x06002671 RID: 9841 RVA: 0x0006B884 File Offset: 0x00069A84
			// (set) Token: 0x06002672 RID: 9842 RVA: 0x000152A1 File Offset: 0x000134A1
			public unsafe UnityEngine.Events.UnityAction callback
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BeforeRenderHelper.OrderBlock.NativeFieldInfoPtr_callback);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEngine.Events.UnityAction>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BeforeRenderHelper.OrderBlock.NativeFieldInfoPtr_callback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001C62 RID: 7266
			private static readonly IntPtr NativeFieldInfoPtr_order;

			// Token: 0x04001C63 RID: 7267
			private static readonly IntPtr NativeFieldInfoPtr_callback;
		}
	}
}
