using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements.UIR
{
	// Token: 0x020000DA RID: 218
	public class BestFitAllocator : Object
	{
		// Token: 0x06000C3A RID: 3130 RVA: 0x000318A8 File Offset: 0x0002FAA8
		// Note: this type is marked as 'beforefieldinit'.
		static BestFitAllocator()
		{
			Il2CppClassPointerStore<BestFitAllocator>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements.UIR", "BestFitAllocator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BestFitAllocator>.NativeClassPtr);
			BestFitAllocator.NativeFieldInfoPtr__totalSize_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BestFitAllocator>.NativeClassPtr, "<totalSize>k__BackingField");
			BestFitAllocator.NativeFieldInfoPtr_m_FirstBlock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BestFitAllocator>.NativeClassPtr, "m_FirstBlock");
			BestFitAllocator.NativeFieldInfoPtr_m_FirstAvailableBlock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BestFitAllocator>.NativeClassPtr, "m_FirstAvailableBlock");
			BestFitAllocator.NativeFieldInfoPtr_m_BlockPool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BestFitAllocator>.NativeClassPtr, "m_BlockPool");
			BestFitAllocator.NativeFieldInfoPtr_m_HighWatermark = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BestFitAllocator>.NativeClassPtr, "m_HighWatermark");
		}

		// Token: 0x06000C3B RID: 3131 RVA: 0x00007BD6 File Offset: 0x00005DD6
		public BestFitAllocator(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000412 RID: 1042
		// (get) Token: 0x06000C3C RID: 3132 RVA: 0x0003193C File Offset: 0x0002FB3C
		// (set) Token: 0x06000C3D RID: 3133 RVA: 0x00007BDF File Offset: 0x00005DDF
		public unsafe uint _totalSize_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BestFitAllocator.NativeFieldInfoPtr__totalSize_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BestFitAllocator.NativeFieldInfoPtr__totalSize_k__BackingField)) = value;
			}
		}

		// Token: 0x17000413 RID: 1043
		// (get) Token: 0x06000C3E RID: 3134 RVA: 0x00031964 File Offset: 0x0002FB64
		// (set) Token: 0x06000C3F RID: 3135 RVA: 0x00007BFA File Offset: 0x00005DFA
		public unsafe BestFitAllocator.Block m_FirstBlock
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BestFitAllocator.NativeFieldInfoPtr_m_FirstBlock);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BestFitAllocator.Block>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BestFitAllocator.NativeFieldInfoPtr_m_FirstBlock), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000414 RID: 1044
		// (get) Token: 0x06000C40 RID: 3136 RVA: 0x00031994 File Offset: 0x0002FB94
		// (set) Token: 0x06000C41 RID: 3137 RVA: 0x00007C19 File Offset: 0x00005E19
		public unsafe BestFitAllocator.Block m_FirstAvailableBlock
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BestFitAllocator.NativeFieldInfoPtr_m_FirstAvailableBlock);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BestFitAllocator.Block>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BestFitAllocator.NativeFieldInfoPtr_m_FirstAvailableBlock), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000415 RID: 1045
		// (get) Token: 0x06000C42 RID: 3138 RVA: 0x000319C4 File Offset: 0x0002FBC4
		// (set) Token: 0x06000C43 RID: 3139 RVA: 0x00007C38 File Offset: 0x00005E38
		public unsafe BestFitAllocator.BlockPool m_BlockPool
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BestFitAllocator.NativeFieldInfoPtr_m_BlockPool);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BestFitAllocator.BlockPool>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BestFitAllocator.NativeFieldInfoPtr_m_BlockPool), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000416 RID: 1046
		// (get) Token: 0x06000C44 RID: 3140 RVA: 0x000319F4 File Offset: 0x0002FBF4
		// (set) Token: 0x06000C45 RID: 3141 RVA: 0x00007C57 File Offset: 0x00005E57
		public unsafe uint m_HighWatermark
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BestFitAllocator.NativeFieldInfoPtr_m_HighWatermark);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BestFitAllocator.NativeFieldInfoPtr_m_HighWatermark)) = value;
			}
		}

		// Token: 0x17000417 RID: 1047
		// (get) Token: 0x06000C46 RID: 3142 RVA: 0x00007C72 File Offset: 0x00005E72
		public uint totalSize
		{
			get
			{
				return this._totalSize_k__BackingField;
			}
		}

		// Token: 0x17000418 RID: 1048
		// (get) Token: 0x06000C47 RID: 3143 RVA: 0x00031A1C File Offset: 0x0002FC1C
		public uint highWatermark
		{
			get
			{
				return this.m_HighWatermark;
			}
		}

		// Token: 0x06000C48 RID: 3144 RVA: 0x00031A34 File Offset: 0x0002FC34
		public Alloc Allocate(uint size)
		{
			BestFitAllocator.Block block = this.BestFitFindAvailableBlock(size);
			bool flag = block == null;
			Alloc alloc;
			if (flag)
			{
				alloc = null;
			}
			else
			{
				Debug.Assert(block.size >= size);
				Debug.Assert(!block.allocated);
				bool flag2 = size != block.size;
				if (flag2)
				{
					this.SplitBlock(block, size);
				}
				Debug.Assert(block.size == size);
				bool flag3 = block.end > this.m_HighWatermark;
				if (flag3)
				{
					this.m_HighWatermark = block.end;
				}
				bool flag4 = block == this.m_FirstAvailableBlock;
				if (flag4)
				{
					this.m_FirstAvailableBlock = this.m_FirstAvailableBlock.nextAvailable;
				}
				bool flag5 = block.prevAvailable != null;
				if (flag5)
				{
					block.prevAvailable.nextAvailable = block.nextAvailable;
				}
				bool flag6 = block.nextAvailable != null;
				if (flag6)
				{
					block.nextAvailable.prevAvailable = block.prevAvailable;
				}
				block.allocated = true;
				block.prevAvailable = (block.nextAvailable = null);
				Alloc alloc2 = null;
				alloc2.start = block.start;
				alloc2.size = block.size;
				alloc2.handle = block;
				alloc = alloc2;
			}
			return alloc;
		}

		// Token: 0x06000C49 RID: 3145 RVA: 0x00031B74 File Offset: 0x0002FD74
		public void Free(Alloc alloc)
		{
			BestFitAllocator.Block block = alloc.handle.Cast<BestFitAllocator.Block>();
			bool flag = !block.allocated;
			if (flag)
			{
				Debug.Assert(false, "Severe error: UIR allocation double-free");
			}
			else
			{
				Debug.Assert(block.allocated);
				Debug.Assert(block.start == alloc.start);
				Debug.Assert(block.size == alloc.size);
				bool flag2 = block.end == this.m_HighWatermark;
				if (flag2)
				{
					bool flag3 = block.prev != null;
					if (flag3)
					{
						this.m_HighWatermark = (block.prev.allocated ? block.prev.end : block.prev.start);
					}
					else
					{
						this.m_HighWatermark = 0U;
					}
				}
				block.allocated = false;
				BestFitAllocator.Block block2 = this.m_FirstAvailableBlock;
				BestFitAllocator.Block block3 = null;
				while (block2 != null && block2.start < block.start)
				{
					block3 = block2;
					block2 = block2.nextAvailable;
				}
				bool flag4 = block3 == null;
				if (flag4)
				{
					Debug.Assert(block.prevAvailable == null);
					block.nextAvailable = this.m_FirstAvailableBlock;
					this.m_FirstAvailableBlock = block;
				}
				else
				{
					block.prevAvailable = block3;
					block.nextAvailable = block3.nextAvailable;
					block3.nextAvailable = block;
				}
				bool flag5 = block.nextAvailable != null;
				if (flag5)
				{
					block.nextAvailable.prevAvailable = block;
				}
				bool flag6 = block.prevAvailable == block.prev && block.prev != null;
				if (flag6)
				{
					block = this.CoalesceBlockWithPrevious(block);
				}
				bool flag7 = block.nextAvailable == block.next && block.next != null;
				if (flag7)
				{
					block = this.CoalesceBlockWithPrevious(block.next);
				}
			}
		}

		// Token: 0x06000C4A RID: 3146 RVA: 0x00031D30 File Offset: 0x0002FF30
		public BestFitAllocator.Block CoalesceBlockWithPrevious(BestFitAllocator.Block block)
		{
			Debug.Assert(block.prevAvailable.end == block.start);
			Debug.Assert(block.prev.nextAvailable == block);
			BestFitAllocator.Block prev = block.prev;
			prev.next = block.next;
			bool flag = block.next != null;
			if (flag)
			{
				block.next.prev = prev;
			}
			prev.nextAvailable = block.nextAvailable;
			bool flag2 = block.nextAvailable != null;
			if (flag2)
			{
				block.nextAvailable.prevAvailable = block.prevAvailable;
			}
			prev.end = block.end;
			this.m_BlockPool.Return(block);
			return prev;
		}

		// Token: 0x06000C4B RID: 3147 RVA: 0x00031DE0 File Offset: 0x0002FFE0
		public BestFitAllocator.Block BestFitFindAvailableBlock(uint size)
		{
			BestFitAllocator.Block block = this.m_FirstAvailableBlock;
			BestFitAllocator.Block block2 = null;
			uint num = uint.MaxValue;
			while (block != null)
			{
				bool flag = block.size >= size && num > block.size;
				if (flag)
				{
					block2 = block;
					num = block.size;
				}
				block = block.nextAvailable;
			}
			return block2;
		}

		// Token: 0x06000C4C RID: 3148 RVA: 0x00031E3C File Offset: 0x0003003C
		public void SplitBlock(BestFitAllocator.Block block, uint size)
		{
			Debug.Assert(block.size > size);
			BestFitAllocator.Block block2 = this.m_BlockPool.Get();
			block2.next = block.next;
			block2.nextAvailable = block.nextAvailable;
			block2.prev = block;
			block2.prevAvailable = block;
			block2.start = block.start + size;
			block2.end = block.end;
			bool flag = block2.next != null;
			if (flag)
			{
				block2.next.prev = block2;
			}
			bool flag2 = block2.nextAvailable != null;
			if (flag2)
			{
				block2.nextAvailable.prevAvailable = block2;
			}
			block.next = block2;
			block.nextAvailable = block2;
			block.end = block2.start;
		}

		// Token: 0x040006A5 RID: 1701
		private static readonly IntPtr NativeFieldInfoPtr__totalSize_k__BackingField;

		// Token: 0x040006A6 RID: 1702
		private static readonly IntPtr NativeFieldInfoPtr_m_FirstBlock;

		// Token: 0x040006A7 RID: 1703
		private static readonly IntPtr NativeFieldInfoPtr_m_FirstAvailableBlock;

		// Token: 0x040006A8 RID: 1704
		private static readonly IntPtr NativeFieldInfoPtr_m_BlockPool;

		// Token: 0x040006A9 RID: 1705
		private static readonly IntPtr NativeFieldInfoPtr_m_HighWatermark;

		// Token: 0x0200022A RID: 554
		public class BlockPool : LinkedPool<BestFitAllocator.Block>
		{
			// Token: 0x060013D8 RID: 5080 RVA: 0x0000CAE8 File Offset: 0x0000ACE8
			// Note: this type is marked as 'beforefieldinit'.
			static BlockPool()
			{
				Il2CppClassPointerStore<BestFitAllocator.BlockPool>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BestFitAllocator>.NativeClassPtr, "BlockPool");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BestFitAllocator.BlockPool>.NativeClassPtr);
			}

			// Token: 0x060013D9 RID: 5081 RVA: 0x0000CB08 File Offset: 0x0000AD08
			public BlockPool(IntPtr pointer)
				: base(pointer)
			{
			}
		}

		// Token: 0x0200022B RID: 555
		public class Block : LinkedPoolItem<BestFitAllocator.Block>
		{
			// Token: 0x060013DA RID: 5082 RVA: 0x0003CBDC File Offset: 0x0003ADDC
			// Note: this type is marked as 'beforefieldinit'.
			static Block()
			{
				Il2CppClassPointerStore<BestFitAllocator.Block>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BestFitAllocator>.NativeClassPtr, "Block");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BestFitAllocator.Block>.NativeClassPtr);
				BestFitAllocator.Block.NativeFieldInfoPtr_start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BestFitAllocator.Block>.NativeClassPtr, "start");
				BestFitAllocator.Block.NativeFieldInfoPtr_end = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BestFitAllocator.Block>.NativeClassPtr, "end");
				BestFitAllocator.Block.NativeFieldInfoPtr_prev = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BestFitAllocator.Block>.NativeClassPtr, "prev");
				BestFitAllocator.Block.NativeFieldInfoPtr_next = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BestFitAllocator.Block>.NativeClassPtr, "next");
				BestFitAllocator.Block.NativeFieldInfoPtr_prevAvailable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BestFitAllocator.Block>.NativeClassPtr, "prevAvailable");
				BestFitAllocator.Block.NativeFieldInfoPtr_nextAvailable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BestFitAllocator.Block>.NativeClassPtr, "nextAvailable");
				BestFitAllocator.Block.NativeFieldInfoPtr_allocated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BestFitAllocator.Block>.NativeClassPtr, "allocated");
			}

			// Token: 0x060013DB RID: 5083 RVA: 0x0000CB11 File Offset: 0x0000AD11
			public Block(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000625 RID: 1573
			// (get) Token: 0x060013DC RID: 5084 RVA: 0x0003CC94 File Offset: 0x0003AE94
			// (set) Token: 0x060013DD RID: 5085 RVA: 0x0000CB1A File Offset: 0x0000AD1A
			public unsafe uint start
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BestFitAllocator.Block.NativeFieldInfoPtr_start);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BestFitAllocator.Block.NativeFieldInfoPtr_start)) = value;
				}
			}

			// Token: 0x17000626 RID: 1574
			// (get) Token: 0x060013DE RID: 5086 RVA: 0x0003CCBC File Offset: 0x0003AEBC
			// (set) Token: 0x060013DF RID: 5087 RVA: 0x0000CB35 File Offset: 0x0000AD35
			public unsafe uint end
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BestFitAllocator.Block.NativeFieldInfoPtr_end);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BestFitAllocator.Block.NativeFieldInfoPtr_end)) = value;
				}
			}

			// Token: 0x17000627 RID: 1575
			// (get) Token: 0x060013E0 RID: 5088 RVA: 0x0003CCE4 File Offset: 0x0003AEE4
			// (set) Token: 0x060013E1 RID: 5089 RVA: 0x0000CB50 File Offset: 0x0000AD50
			public unsafe BestFitAllocator.Block prev
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BestFitAllocator.Block.NativeFieldInfoPtr_prev);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<BestFitAllocator.Block>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BestFitAllocator.Block.NativeFieldInfoPtr_prev), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000628 RID: 1576
			// (get) Token: 0x060013E2 RID: 5090 RVA: 0x0003CD14 File Offset: 0x0003AF14
			// (set) Token: 0x060013E3 RID: 5091 RVA: 0x0000CB6F File Offset: 0x0000AD6F
			public unsafe BestFitAllocator.Block next
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BestFitAllocator.Block.NativeFieldInfoPtr_next);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<BestFitAllocator.Block>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BestFitAllocator.Block.NativeFieldInfoPtr_next), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000629 RID: 1577
			// (get) Token: 0x060013E4 RID: 5092 RVA: 0x0003CD44 File Offset: 0x0003AF44
			// (set) Token: 0x060013E5 RID: 5093 RVA: 0x0000CB8E File Offset: 0x0000AD8E
			public unsafe BestFitAllocator.Block prevAvailable
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BestFitAllocator.Block.NativeFieldInfoPtr_prevAvailable);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<BestFitAllocator.Block>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BestFitAllocator.Block.NativeFieldInfoPtr_prevAvailable), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700062A RID: 1578
			// (get) Token: 0x060013E6 RID: 5094 RVA: 0x0003CD74 File Offset: 0x0003AF74
			// (set) Token: 0x060013E7 RID: 5095 RVA: 0x0000CBAD File Offset: 0x0000ADAD
			public unsafe BestFitAllocator.Block nextAvailable
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BestFitAllocator.Block.NativeFieldInfoPtr_nextAvailable);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<BestFitAllocator.Block>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BestFitAllocator.Block.NativeFieldInfoPtr_nextAvailable), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700062B RID: 1579
			// (get) Token: 0x060013E8 RID: 5096 RVA: 0x0003CDA4 File Offset: 0x0003AFA4
			// (set) Token: 0x060013E9 RID: 5097 RVA: 0x0000CBCC File Offset: 0x0000ADCC
			public unsafe bool allocated
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BestFitAllocator.Block.NativeFieldInfoPtr_allocated);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BestFitAllocator.Block.NativeFieldInfoPtr_allocated)) = value;
				}
			}

			// Token: 0x040008F1 RID: 2289
			private static readonly IntPtr NativeFieldInfoPtr_start;

			// Token: 0x040008F2 RID: 2290
			private static readonly IntPtr NativeFieldInfoPtr_end;

			// Token: 0x040008F3 RID: 2291
			private static readonly IntPtr NativeFieldInfoPtr_prev;

			// Token: 0x040008F4 RID: 2292
			private static readonly IntPtr NativeFieldInfoPtr_next;

			// Token: 0x040008F5 RID: 2293
			private static readonly IntPtr NativeFieldInfoPtr_prevAvailable;

			// Token: 0x040008F6 RID: 2294
			private static readonly IntPtr NativeFieldInfoPtr_nextAvailable;

			// Token: 0x040008F7 RID: 2295
			private static readonly IntPtr NativeFieldInfoPtr_allocated;
		}
	}
}
